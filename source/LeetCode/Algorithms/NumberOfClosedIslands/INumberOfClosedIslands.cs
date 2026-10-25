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

namespace LeetCode.Algorithms.NumberOfClosedIslands;

/// <summary>
///     https://leetcode.com/problems/number-of-closed-islands/description/
/// </summary>
public interface INumberOfClosedIslands
{
    /// <summary>
    ///     Counts the islands of 4-directionally connected land cells that are completely surrounded by water, meaning
    ///     no cell of the island lies on the border of the grid.
    /// </summary>
    /// <param name="grid">The binary matrix where 0 is land and 1 is water.</param>
    /// <returns>The number of closed islands in <paramref name="grid" />.</returns>
    int ClosedIsland(int[][] grid);
}