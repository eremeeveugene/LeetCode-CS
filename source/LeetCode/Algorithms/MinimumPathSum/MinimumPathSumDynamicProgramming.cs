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

/// <inheritdoc />
public sealed class MinimumPathSumDynamicProgramming : IMinimumPathSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinPathSum(int[][] grid)
    {
        var n = grid[0].Length;

        Span<int> rowSums = stackalloc int[n];

        rowSums[0] = grid[0][0];

        for (var i = 1; i < n; i++)
        {
            rowSums[i] = rowSums[i - 1] + grid[0][i];
        }

        for (var i = 1; i < grid.Length; i++)
        {
            rowSums[0] += grid[i][0];

            for (var j = 1; j < n; j++)
            {
                rowSums[j] = Math.Min(rowSums[j], rowSums[j - 1]) + grid[i][j];
            }
        }

        return rowSums[n - 1];
    }
}