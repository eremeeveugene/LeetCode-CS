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

namespace LeetCode.Algorithms.Shift2DGrid;

/// <summary>
///     https://leetcode.com/problems/shift-2d-grid/description/
/// </summary>
public interface IShift2DGrid
{
    /// <summary>
    ///     Shifts the grid k times, moving each element one cell to the right, the last element of each row to the first
    ///     cell of the next row, and the last element of the grid to the first cell of the grid.
    /// </summary>
    /// <param name="grid">The 2D grid of integers to shift.</param>
    /// <param name="k">The number of shift operations to apply.</param>
    /// <returns>The grid after applying k shift operations.</returns>
    IList<IList<int>> ShiftGrid(int[][] grid, int k);
}