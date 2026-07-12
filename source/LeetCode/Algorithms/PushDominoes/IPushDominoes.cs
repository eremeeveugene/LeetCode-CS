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

namespace LeetCode.Algorithms.PushDominoes;

/// <summary>
///     https://leetcode.com/problems/push-dominoes/description/
/// </summary>
public interface IPushDominoes
{
    /// <summary>
    ///     Simulates the falling of dominoes described by <paramref name="dominoes" /> until they reach a stable
    ///     configuration.
    /// </summary>
    /// <param name="dominoes">
    ///     The string describing the initial state of each domino, where 'L' means falling left, 'R' means falling
    ///     right, and '.' means standing.
    /// </param>
    /// <returns>The final, stable state of the dominoes.</returns>
    string PushDominoes(string dominoes);
}