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
public sealed class MinimumOperationsToMakeUniValueGridSorting : IMinimumOperationsToMakeUniValueGrid
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
        var remainder = grid[0][0] % x;

        var items = new List<int>(rows * cols);

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

                items.Add(cell);
            }
        }

        items.Sort();

        var median = items[items.Count / 2];

        var operations = 0;

        for (var i = 0; i < items.Count; i++)
        {
            var item = items[i];

            operations += Math.Abs(item - median) / x;
        }

        return operations;
    }
}