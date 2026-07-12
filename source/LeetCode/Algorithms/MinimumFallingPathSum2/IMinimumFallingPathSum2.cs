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

namespace LeetCode.Algorithms.MinimumFallingPathSum2;

/// <summary>
///     https://leetcode.com/problems/minimum-falling-path-sum-ii/
/// </summary>
public interface IMinimumFallingPathSum2
{
    /// <summary>
    ///     Finds the minimum sum of a falling path through <paramref name="grid" />, where each step moves to the
    ///     next row into a column different from the one used in the previous row.
    /// </summary>
    /// <param name="grid">The square grid of integers to traverse.</param>
    /// <returns>The minimum sum of a falling path with non-repeating column indices.</returns>
    int MinFallingPathSum(int[][] grid);
}