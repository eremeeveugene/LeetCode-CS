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

namespace LeetCode.Algorithms.IslandPerimeter;

/// <summary>
///     https://leetcode.com/problems/island-perimeter/
/// </summary>
public interface IIslandPerimeter
{
    /// <summary>
    ///     Computes the perimeter of the island formed by the land cells in <paramref name="grid" />.
    /// </summary>
    /// <param name="grid">The grid where 1 represents land and 0 represents water.</param>
    /// <returns>The perimeter of the island.</returns>
    int IslandPerimeter(int[][] grid);
}