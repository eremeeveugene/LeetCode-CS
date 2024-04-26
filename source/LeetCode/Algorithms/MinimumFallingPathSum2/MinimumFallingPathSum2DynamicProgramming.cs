// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.MinimumFallingPathSum2;

/// <inheritdoc />
public class MinimumFallingPathSum2DynamicProgramming : IMinimumFallingPathSum2
{
    public int MinFallingPathSum(int[][] grid)
    {
        var n = grid.Length;

        if (n == 1)
        {
            return grid[0][0];
        }

        var dp = new int[n];

        Array.Copy(grid[0], dp, n);

        for (var i = 1; i < n; i++)
        {
            var prev = new int[n];

            Array.Copy(dp, prev, n);

            var newDp = new int[n];

            int min1 = int.MaxValue, min2 = int.MaxValue;
            var idx1 = -1;

            for (var j = 0; j < n; j++)
            {
                if (prev[j] < min1)
                {
                    min2 = min1;
                    min1 = prev[j];
                    idx1 = j;
                }
                else if (prev[j] < min2)
                {
                    min2 = prev[j];
                }
            }

            for (var j = 0; j < n; j++)
            {
                if (j == idx1)
                {
                    newDp[j] = grid[i][j] + min2;
                }
                else
                {
                    newDp[j] = grid[i][j] + min1;
                }
            }

            dp = newDp;
        }

        return dp.Prepend(int.MaxValue).Min();
    }
}