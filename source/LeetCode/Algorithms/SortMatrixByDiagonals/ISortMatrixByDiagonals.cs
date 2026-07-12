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

namespace LeetCode.Algorithms.SortMatrixByDiagonals;

/// <summary>
///     https://leetcode.com/problems/sort-matrix-by-diagonals/description/
/// </summary>
public interface ISortMatrixByDiagonals
{
    /// <summary>
    ///     Sorts each diagonal of the square matrix <paramref name="grid" /> independently: diagonals in the
    ///     bottom-left triangle (including the main diagonal) are sorted in non-increasing order from top-left
    ///     to bottom-right, and diagonals in the top-right triangle are sorted in non-decreasing order.
    /// </summary>
    /// <param name="grid">The square matrix whose diagonals are to be sorted.</param>
    /// <returns>The matrix <paramref name="grid" /> after each diagonal has been sorted.</returns>
    int[][] SortMatrix(int[][] grid);
}