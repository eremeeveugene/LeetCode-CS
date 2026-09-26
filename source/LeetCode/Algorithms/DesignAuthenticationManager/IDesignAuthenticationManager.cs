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

/// <summary>
///     https://leetcode.com/problems/design-authentication-manager/description/
/// </summary>
public interface IDesignAuthenticationManager
{
    /// <summary>
    ///     Generates a token that expires after the configured time to live.
    /// </summary>
    /// <param name="tokenId">The unique token identifier.</param>
    /// <param name="currentTime">The current time in seconds.</param>
    void Generate(string tokenId, int currentTime);

    /// <summary>
    ///     Extends an unexpired token's lifetime from the current time; ignores missing or expired tokens.
    /// </summary>
    /// <param name="tokenId">The token identifier to renew.</param>
    /// <param name="currentTime">The current time in seconds.</param>
    void Renew(string tokenId, int currentTime);

    /// <summary>
    ///     Counts tokens whose expiration time is strictly greater than the current time.
    /// </summary>
    /// <param name="currentTime">The current time in seconds.</param>
    /// <returns>The number of unexpired tokens.</returns>
    int CountUnexpiredTokens(int currentTime);
}