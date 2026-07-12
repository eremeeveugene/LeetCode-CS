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

namespace LeetCode.Algorithms.CountUnguardedCellsInTheGrid;

/// <summary>
///     https://leetcode.com/problems/count-unguarded-cells-in-the-grid/description/
/// </summary>
public interface ICountUnguardedCellsInTheGrid
{
    /// <summary>
    ///     Counts the unguarded cells in an <paramref name="m" /> by <paramref name="n" /> grid containing the given
    ///     <paramref name="guards" /> and <paramref name="walls" />, where a cell is guarded if it is visible to any
    ///     guard along a row or column not blocked by another guard or a wall.
    /// </summary>
    /// <param name="m">The number of rows in the grid.</param>
    /// <param name="n">The number of columns in the grid.</param>
    /// <param name="guards">The positions of the guards in the grid.</param>
    /// <param name="walls">The positions of the walls in the grid.</param>
    /// <returns>The number of cells that are not occupied by a guard or wall and are not guarded.</returns>
    int CountUnguarded(int m, int n, int[][] guards, int[][] walls);
}