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

namespace LeetCode.Algorithms.MinimumTimeToVisitCellInGrid;

/// <summary>
///     https://leetcode.com/problems/minimum-time-to-visit-a-cell-in-a-grid/description/
/// </summary>
public interface IMinimumTimeToVisitCellInGrid
{
    /// <summary>
    ///     Finds the minimum time required to reach the bottom-right cell of <paramref name="grid" /> starting from
    ///     the top-left cell at time 0, where a cell can only be entered at or after the time value stored in it.
    /// </summary>
    /// <param name="grid">The grid where each cell holds the earliest time at which it can be visited.</param>
    /// <returns>The minimum time needed to reach the bottom-right cell, or -1 if it is unreachable.</returns>
    int MinimumTime(int[][] grid);
}