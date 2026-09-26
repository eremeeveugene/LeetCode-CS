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
///     Space complexity - O(n), where n is the number of generated tokens
/// </remarks>
public sealed class DesignAuthenticationManagerDictionary : IDesignAuthenticationManager
{
    private readonly LinkedList<int> _expirationTimes = [];
    private readonly int _timeToLive;
    private readonly Dictionary<string, LinkedListNode<int>> _tokenIdToNodeDictionary = [];

    public DesignAuthenticationManagerDictionary(int timeToLive)
    {
        _timeToLive = timeToLive;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Generate(string tokenId, int currentTime)
    {
        var expirationTime = currentTime + _timeToLive;
        var node = _expirationTimes.AddLast(expirationTime);

        _tokenIdToNodeDictionary.Add(tokenId, node);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Renew(string tokenId, int currentTime)
    {
        if (!_tokenIdToNodeDictionary.TryGetValue(tokenId, out var node) || node.Value <= currentTime)
        {
            return;
        }

        node.Value = currentTime + _timeToLive;

        _expirationTimes.Remove(node);
        _expirationTimes.AddLast(node);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(u + 1), where u is the number of unexpired tokens
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountUnexpiredTokens(int currentTime)
    {
        var count = 0;
        var node = _expirationTimes.Last;

        while (node is not null && node.Value > currentTime)
        {
            count++;

            node = node.Previous;
        }

        return count;
    }
}