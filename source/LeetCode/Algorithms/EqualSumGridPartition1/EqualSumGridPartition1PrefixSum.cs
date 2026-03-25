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

namespace LeetCode.Algorithms.EqualSumGridPartition1;

/// <inheritdoc />
public sealed class EqualSumGridPartition1PrefixSum : IEqualSumGridPartition1
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public bool CanPartitionGrid(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        long totalSum = 0;

        for (var i = 0; i < m; i++)
        {
            var row = grid[i];

            for (var j = 0; j < n; j++)
            {
                var value = row[j];

                totalSum += value;
            }
        }

        long topSum = 0;
        var bottomSum = totalSum;

        for (var i = 0; i < m - 1; i++)
        {
            var row = grid[i];

            for (var j = 0; j < n; j++)
            {
                var value = row[j];

                topSum += value;
                bottomSum -= value;
            }

            if (topSum == bottomSum)
            {
                return true;
            }
        }

        long leftSum = 0;
        var rightSum = totalSum;

        for (var j = 0; j < n - 1; j++)
        {
            for (var i = 0; i < m; i++)
            {
                var value = grid[i][j];

                leftSum += value;
                rightSum -= value;
            }

            if (leftSum == rightSum)
            {
                return true;
            }
        }

        return false;
    }
}