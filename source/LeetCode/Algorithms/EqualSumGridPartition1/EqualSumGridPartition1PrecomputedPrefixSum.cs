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
public sealed class EqualSumGridPartition1PrecomputedPrefixSum : IEqualSumGridPartition1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m + n)
    /// </remarks>
    public bool CanPartitionGrid(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        Span<long> rowSums = stackalloc long[m];
        Span<long> columnSums = stackalloc long[n];

        long totalSum = 0;

        for (var i = 0; i < m; i++)
        {
            var row = grid[i];

            for (var j = 0; j < n; j++)
            {
                var value = row[j];

                rowSums[i] += value;
                columnSums[j] += value;
                totalSum += value;
            }
        }

        if (totalSum % 2 != 0)
        {
            return false;
        }

        var targetSum = totalSum / 2;

        long rowSum = 0;

        for (var i = 0; i < m - 1; i++)
        {
            rowSum += rowSums[i];

            if (rowSum == targetSum)
            {
                return true;
            }
        }

        long columnSum = 0;

        for (var j = 0; j < n - 1; j++)
        {
            columnSum += columnSums[j];

            if (columnSum == targetSum)
            {
                return true;
            }
        }

        return false;
    }
}