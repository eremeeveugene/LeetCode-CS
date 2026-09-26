// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DesignAuthenticationManager;

/// <inheritdoc />
/// <remarks>
///     Keeps expiration times ordered in a linked list, moving renewed tokens to the end.
///     Removes expired tokens before each operation. Each generated token is removed at most once.
///     Space complexity - O(n), where n is the maximum number of simultaneously stored tokens
/// </remarks>
public sealed class DesignAuthenticationManagerDictionaryWithLinkedList : IDesignAuthenticationManager
{
    private readonly int _timeToLive;
    private readonly Dictionary<string, LinkedListNode<(string TokenId, int ExpirationTime)>> _tokenIdToNodeDictionary = [];
    private readonly LinkedList<(string TokenId, int ExpirationTime)> _tokensByExpirationTime = [];

    public DesignAuthenticationManagerDictionaryWithLinkedList(int timeToLive)
    {
        _timeToLive = timeToLive;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1)
    /// </remarks>
    public void Generate(string tokenId, int currentTime)
    {
        DeleteExpiredTokens(currentTime);

        var expirationTime = currentTime + _timeToLive;
        var node = _tokensByExpirationTime.AddLast((tokenId, expirationTime));

        _tokenIdToNodeDictionary.Add(tokenId, node);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1)
    /// </remarks>
    public void Renew(string tokenId, int currentTime)
    {
        DeleteExpiredTokens(currentTime);

        if (!_tokenIdToNodeDictionary.TryGetValue(tokenId, out var node))
        {
            return;
        }

        node.Value = (tokenId, currentTime + _timeToLive);

        _tokensByExpirationTime.Remove(node);
        _tokensByExpirationTime.AddLast(node);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountUnexpiredTokens(int currentTime)
    {
        DeleteExpiredTokens(currentTime);

        return _tokenIdToNodeDictionary.Count;
    }

    /// <summary>
    ///     Removes expired tokens from the front of the ordered list and from the dictionary.
    /// </summary>
    /// <remarks>
    ///     Time complexity - O(e + 1), where e is the number of tokens removed
    ///     Space complexity - O(1)
    /// </remarks>
    private void DeleteExpiredTokens(int currentTime)
    {
        var node = _tokensByExpirationTime.First;

        while (node is not null && node.Value.ExpirationTime <= currentTime)
        {
            _tokenIdToNodeDictionary.Remove(node.Value.TokenId);
            _tokensByExpirationTime.RemoveFirst();

            node = _tokensByExpirationTime.First;
        }
    }
}