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

namespace LeetCode.Algorithms.MinimumCostToMakeAtLeastOneValidPathInGrid;

/// <summary>
///     https://leetcode.com/problems/minimum-cost-to-make-at-least-one-valid-path-in-a-grid/description/
/// </summary>
public interface IMinimumCostToMakeAtLeastOneValidPathInGrid
{
    /// <summary>
    ///     Finds the minimum cost to modify directions in <paramref name="grid" />, where changing the direction of
    ///     a cell costs 1, so that there is a valid path from the top-left cell to the bottom-right cell following
    ///     the cell directions.
    /// </summary>
    /// <param name="grid">The grid where each cell points to an adjacent cell (right, left, down, or up).</param>
    /// <returns>The minimum cost to make at least one valid path from the top-left to the bottom-right cell.</returns>
    int MinCost(int[][] grid);
}