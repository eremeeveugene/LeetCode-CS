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

namespace LeetCode.Algorithms.NumberOfClosedIslands;

/// <inheritdoc />
public sealed class NumberOfClosedIslandsBreadthFirstSearch : INumberOfClosedIslands
{
    private const int Land = 0;
    private const int Water = 1;

    private static readonly (int Row, int Column)[] Directions = [(1, 0), (-1, 0), (0, 1), (0, -1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int ClosedIsland(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var queue = new Queue<(int Row, int Column)>();

        var closedIslandsCount = 0;

        for (var row = 0; row < m; row++)
        {
            for (var column = 0; column < n; column++)
            {
                if (grid[row][column] != Land)
                {
                    continue;
                }

                var isClosed = GetIsClosed(grid, m, n, queue, row, column);

                if (isClosed)
                {
                    closedIslandsCount++;
                }
            }
        }

        return closedIslandsCount;
    }

    /// <summary>
    ///     Floods the island containing the given land cell with water and checks whether none of its cells lies on the
    ///     border of the grid.
    /// </summary>
    /// <param name="grid">The binary matrix where 0 is land and 1 is water.</param>
    /// <param name="m">The number of rows in <paramref name="grid" />.</param>
    /// <param name="n">The number of columns in <paramref name="grid" />.</param>
    /// <param name="queue">The empty queue reused for the traversal.</param>
    /// <param name="startRow">The row of the land cell to start from.</param>
    /// <param name="startColumn">The column of the land cell to start from.</param>
    /// <returns>
    ///     <see langword="true" /> if no cell of the island lies on the border of the grid; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    private static bool GetIsClosed(int[][] grid, int m, int n, Queue<(int Row, int Column)> queue, int startRow, int startColumn)
    {
        grid[startRow][startColumn] = Water;

        queue.Enqueue((startRow, startColumn));

        var isClosed = true;

        while (queue.Count > 0)
        {
            var (row, column) = queue.Dequeue();

            if (row == 0 || column == 0 || row == m - 1 || column == n - 1)
            {
                isClosed = false;
            }

            for (var i = 0; i < Directions.Length; i++)
            {
                var direction = Directions[i];

                var nextRow = row + direction.Row;
                var nextColumn = column + direction.Column;

                if (nextRow < 0 || nextColumn < 0 || nextRow >= m || nextColumn >= n || grid[nextRow][nextColumn] != Land)
                {
                    continue;
                }

                grid[nextRow][nextColumn] = Water;

                queue.Enqueue((nextRow, nextColumn));
            }
        }

        return isClosed;
    }
}