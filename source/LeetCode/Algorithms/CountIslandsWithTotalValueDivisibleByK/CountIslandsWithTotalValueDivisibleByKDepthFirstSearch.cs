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

namespace LeetCode.Algorithms.CountIslandsWithTotalValueDivisibleByK;

/// <inheritdoc />
public sealed class CountIslandsWithTotalValueDivisibleByKDepthFirstSearch : ICountIslandsWithTotalValueDivisibleByK
{
    private const int Water = 0;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int CountIslands(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var count = 0;

        for (var i = 0; i < m; i++)
        {
            var row = grid[i];

            for (var j = 0; j < n; j++)
            {
                var cell = row[j];

                if (cell == Water)
                {
                    continue;
                }

                var totalValueRemainder = GetTotalValueRemainder(grid, m, n, k, i, j);

                if (totalValueRemainder == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }

    /// <summary>
    ///     Floods the unvisited land reachable from the given cell with water and computes its total value modulo
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="grid">The matrix where positive values are land and 0 is water.</param>
    /// <param name="m">The number of rows in <paramref name="grid" />.</param>
    /// <param name="n">The number of columns in <paramref name="grid" />.</param>
    /// <param name="k">The positive divisor.</param>
    /// <param name="i">The row of the cell to visit.</param>
    /// <param name="j">The column of the cell to visit.</param>
    /// <returns>The total value of the land reachable from the given cell modulo <paramref name="k" />.</returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    private static int GetTotalValueRemainder(int[][] grid, int m, int n, int k, int i, int j)
    {
        if (i < 0 || j < 0 || i >= m || j >= n)
        {
            return 0;
        }

        var value = grid[i][j];

        if (value == Water)
        {
            return 0;
        }

        grid[i][j] = Water;

        var valueRemainder = value % k;
        var downRemainder = GetTotalValueRemainder(grid, m, n, k, i + 1, j);
        var upRemainder = GetTotalValueRemainder(grid, m, n, k, i - 1, j);
        var rightRemainder = GetTotalValueRemainder(grid, m, n, k, i, j + 1);
        var leftRemainder = GetTotalValueRemainder(grid, m, n, k, i, j - 1);

        var totalValue = valueRemainder + downRemainder + upRemainder + rightRemainder + leftRemainder;

        return totalValue % k;
    }
}