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

namespace LeetCode.Algorithms.NumberOfIslands;

/// <summary>
///     https://leetcode.com/problems/number-of-islands/description/
/// </summary>
public interface INumberOfIslands
{
    /// <summary>
    ///     Counts the number of islands in <paramref name="grid" />, where an island is a group of '1' cells
    ///     connected horizontally or vertically and surrounded by water ('0') cells or the grid edges.
    /// </summary>
    /// <param name="grid">The grid of '1' (land) and '0' (water) characters.</param>
    /// <returns>The number of islands in <paramref name="grid" />.</returns>
    int NumIslands(char[][] grid);
}