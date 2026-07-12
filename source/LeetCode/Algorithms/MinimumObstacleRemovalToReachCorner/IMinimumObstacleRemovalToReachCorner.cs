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

namespace LeetCode.Algorithms.MinimumObstacleRemovalToReachCorner;

/// <summary>
///     https://leetcode.com/problems/minimum-obstacle-removal-to-reach-corner/description/
/// </summary>
public interface IMinimumObstacleRemovalToReachCorner
{
    /// <summary>
    ///     Determines the minimum number of obstacles that must be removed from <paramref name="grid" /> to travel
    ///     from the top-left cell to the bottom-right cell.
    /// </summary>
    /// <param name="grid">The grid where each cell is either 0 (empty) or 1 (obstacle).</param>
    /// <returns>The minimum number of obstacles to remove to reach the bottom-right corner.</returns>
    int MinimumObstacles(int[][] grid);
}