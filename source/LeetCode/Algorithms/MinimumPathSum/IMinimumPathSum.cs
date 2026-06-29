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

namespace LeetCode.Algorithms.MinimumPathSum;

/// <summary>
///     https://leetcode.com/problems/minimum-path-sum/description/
/// </summary>
public interface IMinimumPathSum
{
    /// <summary>
    ///     Finds the minimum sum of all numbers along a path from the top-left cell <c>(0, 0)</c> to the bottom-right cell
    ///     <c>(m - 1, n - 1)</c> of <paramref name="grid" />, where each move travels only down or right.
    /// </summary>
    /// <param name="grid">
    ///     An <c>m x n</c> grid of non-negative integers, with <c>1 &lt;= m, n &lt;= 200</c> and
    ///     <c>0 &lt;= grid[i][j] &lt;= 200</c>.
    /// </param>
    /// <returns>The minimum path sum from the top-left cell to the bottom-right cell.</returns>
    int MinPathSum(int[][] grid);
}