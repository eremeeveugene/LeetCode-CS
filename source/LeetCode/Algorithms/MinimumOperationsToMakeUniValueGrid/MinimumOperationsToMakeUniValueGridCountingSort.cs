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

/// <inheritdoc />
public sealed class MinimumOperationsToMakeUniValueGridCountingSort : IMinimumOperationsToMakeUniValueGrid
{
    private const int MaxValue = 10_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinOperations(int[][] grid, int x)
    {
        Span<int> frequencies = stackalloc int[MaxValue + 1];

        var remainder = grid[0][0] % x;

        for (var i = 0; i < grid.Length; i++)
        {
            var row = grid[i];

            for (var j = 0; j < row.Length; j++)
            {
                var cell = row[j];

                if (cell % x != remainder)
                {
                    return -1;
                }

                frequencies[cell]++;
            }
        }

        var rows = grid.Length;
        var cols = grid[0].Length;
        var gridLength = rows * cols;

        var medianIndex = gridLength / 2;

        var currentCount = 0;
        var median = 0;

        for (var value = 1; value <= MaxValue; value++)
        {
            currentCount += frequencies[value];

            if (currentCount > medianIndex)
            {
                median = value;

                break;
            }
        }

        var operations = 0;

        for (var value = 1; value <= MaxValue; value++)
        {
            var frequency = frequencies[value];

            if (frequency == 0)
            {
                continue;
            }

            operations += frequency * (Math.Abs(value - median) / x);
        }

        return operations;
    }
}