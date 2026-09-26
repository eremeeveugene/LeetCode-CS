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
///     Space complexity - O(n), where n is the number of generated tokens
/// </remarks>
public sealed class DesignAuthenticationManagerDictionary : IDesignAuthenticationManager
{
    private readonly int _timeToLive;
    private readonly Dictionary<string, int> _tokenIdToExpirationTimeDictionary = [];

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

        _tokenIdToExpirationTimeDictionary.Add(tokenId, expirationTime);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Renew(string tokenId, int currentTime)
    {
        if (!_tokenIdToExpirationTimeDictionary.TryGetValue(tokenId, out var expirationTime) || expirationTime <= currentTime)
        {
            return;
        }

        expirationTime = currentTime + _timeToLive;

        _tokenIdToExpirationTimeDictionary[tokenId] = expirationTime;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of generated tokens
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountUnexpiredTokens(int currentTime)
    {
        var count = 0;

        foreach (var expirationTime in _tokenIdToExpirationTimeDictionary.Values)
        {
            if (expirationTime > currentTime)
            {
                count++;
            }
        }

        return count;
    }
}