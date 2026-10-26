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
public sealed class CountIslandsWithTotalValueDivisibleByKBreadthFirstSearch : ICountIslandsWithTotalValueDivisibleByK
{
    private const int Water = 0;

    private static readonly (int Row, int Column)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int CountIslands(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var queue = new Queue<(int Row, int Column)>();

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

                var totalValueRemainder = GetTotalValueRemainder(grid, m, n, k, queue, i, j);

                if (totalValueRemainder == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }

    /// <summary>
    ///     Floods the island containing the given land cell with water and computes its total value modulo
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="grid">The matrix where positive values are land and 0 is water.</param>
    /// <param name="m">The number of rows in <paramref name="grid" />.</param>
    /// <param name="n">The number of columns in <paramref name="grid" />.</param>
    /// <param name="k">The positive divisor.</param>
    /// <param name="queue">The empty queue reused for the traversal.</param>
    /// <param name="startRow">The row of the land cell to start from.</param>
    /// <param name="startColumn">The column of the land cell to start from.</param>
    /// <returns>The total value of the island modulo <paramref name="k" />.</returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    private static int GetTotalValueRemainder(int[][] grid, int m, int n, int k, Queue<(int Row, int Column)> queue, int startRow, int startColumn)
    {
        var totalValueRemainder = grid[startRow][startColumn] % k;

        grid[startRow][startColumn] = Water;

        queue.Enqueue((startRow, startColumn));

        while (queue.Count > 0)
        {
            var (row, column) = queue.Dequeue();

            for (var i = 0; i < Directions.Length; i++)
            {
                var direction = Directions[i];

                var nextRow = row + direction.Row;
                var nextColumn = column + direction.Column;

                if (nextRow < 0 || nextColumn < 0 || nextRow >= m || nextColumn >= n)
                {
                    continue;
                }

                var value = grid[nextRow][nextColumn];

                if (value == Water)
                {
                    continue;
                }

                totalValueRemainder = (totalValueRemainder + value) % k;

                grid[nextRow][nextColumn] = Water;

                queue.Enqueue((nextRow, nextColumn));
            }
        }

        return totalValueRemainder;
    }
}