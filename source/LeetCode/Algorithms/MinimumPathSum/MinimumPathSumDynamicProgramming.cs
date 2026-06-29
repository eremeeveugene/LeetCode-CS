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
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinPathSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i == 0 && j == 0)
                {
                    continue;
                }

                if (i == 0)
                {
                    grid[i][j] += grid[i][j - 1];
                }
                else if (j == 0)
                {
                    grid[i][j] += grid[i - 1][j];
                }
                else
                {
                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                }
            }
        }

        return grid[m - 1][n - 1];
    }
}