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

namespace LeetCode.Algorithms.MinimumNumberOfDaysToDisconnectIsland;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-days-to-disconnect-island/
/// </summary>
public interface IMinimumNumberOfDaysToDisconnectIsland
{
    /// <summary>
    ///     Finds the minimum number of days needed, converting one land cell to water per day, to disconnect the
    ///     island represented by <paramref name="grid" /> into two or more islands, or to make it disappear
    ///     entirely.
    /// </summary>
    /// <param name="grid">The binary grid where 1 represents land and 0 represents water.</param>
    /// <returns>The minimum number of days required to disconnect the island.</returns>
    int MinDays(int[][] grid);
}