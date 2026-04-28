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

namespace LeetCode.Algorithms.MinimumOperationsToMakeUniValueGrid;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-make-a-uni-value-grid/description/
/// </summary>
public interface IMinimumOperationsToMakeUniValueGrid
{
    /// <summary>
    ///     Calculates the minimum number of operations needed to make all grid values equal.
    /// </summary>
    /// <param name="grid">A 2D integer grid.</param>
    /// <param name="x">The value added to or subtracted from a grid element in one operation.</param>
    /// <returns>The minimum number of operations, or -1 if making the grid uni-value is impossible.</returns>
    int MinOperations(int[][] grid, int x);
}