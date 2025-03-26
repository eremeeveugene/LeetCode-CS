// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MinimumOperationsToMakeUniValueGridSorting : IMinimumOperationsToMakeUniValueGrid
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public int MinOperations(int[][] grid, int x)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var remainder = grid[0][0] % x;

        var items = new List<int>(rows * cols);

        foreach (var row in grid)
        {
            foreach (var cell in row)
            {
                if (cell % x != remainder)
                {
                    return -1;
                }

                items.Add(cell);
            }
        }

        items.Sort();

        var median = items[items.Count / 2];

        return items.Sum(item => Math.Abs(item - median) / x);
    }
}