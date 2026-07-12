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

namespace LeetCode.Algorithms.SpiralMatrix3;

/// <summary>
///     https://leetcode.com/problems/spiral-matrix-iii/
/// </summary>
public interface ISpiralMatrix3
{
    /// <summary>
    ///     Visits every cell of a <paramref name="rows" /> by <paramref name="cols" /> grid in a clockwise
    ///     spiral, starting at (<paramref name="rStart" />, <paramref name="cStart" />) and continuing outward
    ///     even beyond the grid boundaries until all cells within it are visited.
    /// </summary>
    /// <param name="rows">The number of rows in the grid.</param>
    /// <param name="cols">The number of columns in the grid.</param>
    /// <param name="rStart">The row index at which the spiral begins.</param>
    /// <param name="cStart">The column index at which the spiral begins.</param>
    /// <returns>An array of [row, column] coordinates in the order they are visited by the spiral.</returns>
    int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart);
}