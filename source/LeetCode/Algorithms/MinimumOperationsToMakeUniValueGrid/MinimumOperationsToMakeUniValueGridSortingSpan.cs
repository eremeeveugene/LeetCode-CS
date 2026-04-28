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
public sealed class MinimumOperationsToMakeUniValueGridSortingSpan : IMinimumOperationsToMakeUniValueGrid
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n log m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int MinOperations(int[][] grid, int x)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var valuesLength = rows * cols;

        Span<int> values = stackalloc int[valuesLength];

        var itemsIndex = 0;

        var remainder = grid[0][0] % x;

        for (var i = 0; i < grid.Length; i++)
        {
            var row = grid[i];

            for (var j = 0; j < row.Length; j++)
            {
                var cell = row[j];

                if (cell % x == remainder)
                {
                    values[itemsIndex] = cell;

                    itemsIndex++;
                }
                else
                {
                    return -1;
                }
            }
        }

        values.Sort();

        var median = values[valuesLength / 2];

        var operations = 0;

        for (var i = 0; i < valuesLength; i++)
        {
            var value = values[i];

            operations += Math.Abs(value - median) / x;
        }

        return operations;
    }
}