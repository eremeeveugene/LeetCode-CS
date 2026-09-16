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

namespace LeetCode.Algorithms.CyclicallyShiftRowsAndColumns;

/// <summary>
///     https://leetcode.com/problems/cyclically-shift-rows-and-columns/description/
/// </summary>
public interface ICyclicallyShiftRowsAndColumns
{
    /// <summary>
    ///     Cyclically shifts each row to the left, then each column upward.
    /// </summary>
    /// <param name="n">The number of rows and columns in the square grid.</param>
    /// <param name="grid">The grid to shift.</param>
    /// <param name="rowShift">The number of positions to shift each row left.</param>
    /// <param name="colShift">The number of positions to shift each column upward.</param>
    /// <returns>The grid after applying the row shifts followed by the column shifts.</returns>
    int[][] CyclicShift(int n, int[][] grid, int[] rowShift, int[] colShift);
}