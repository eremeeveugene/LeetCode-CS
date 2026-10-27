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

using System.Runtime.CompilerServices;

namespace LeetCode.Algorithms.CountIslandsWithTotalValueDivisibleByK;

/// <inheritdoc />
public sealed class CountIslandsWithTotalValueDivisibleByKBreadthFirstSearch : ICountIslandsWithTotalValueDivisibleByK
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

        var queueRows = new int[m * n];
        var queueColumns = new int[m * n];

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

                var totalValue = GetTotalValue(grid, m, n, queueRows, queueColumns, i, j);

                if (totalValue % k == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }

    /// <summary>
    ///     Floods the island containing the given land cell with water and computes its total value.
    /// </summary>
    /// <param name="grid">The matrix where positive values are land and 0 is water.</param>
    /// <param name="m">The number of rows in <paramref name="grid" />.</param>
    /// <param name="n">The number of columns in <paramref name="grid" />.</param>
    /// <param name="queueRows">The buffer reused for the row indices of the queued cells.</param>
    /// <param name="queueColumns">The buffer reused for the column indices of the queued cells.</param>
    /// <param name="startRow">The row of the land cell to start from.</param>
    /// <param name="startColumn">The column of the land cell to start from.</param>
    /// <returns>The total value of the island.</returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static long GetTotalValue(int[][] grid, int m, int n, int[] queueRows, int[] queueColumns, int startRow, int startColumn)
    {
        var totalValue = 0L;

        var startGridRow = grid[startRow];

        var queueHead = 0;
        var queueTail = EnqueueIfLand(startGridRow, startRow, startColumn, queueRows, queueColumns, 0, ref totalValue);

        while (queueHead < queueTail)
        {
            var row = queueRows[queueHead];
            var column = queueColumns[queueHead];

            queueHead++;

            var gridRow = grid[row];

            if (column > 0)
            {
                queueTail = EnqueueIfLand(gridRow, row, column - 1, queueRows, queueColumns, queueTail, ref totalValue);
            }

            if (column < n - 1)
            {
                queueTail = EnqueueIfLand(gridRow, row, column + 1, queueRows, queueColumns, queueTail, ref totalValue);
            }

            if (row > 0)
            {
                var upGridRow = grid[row - 1];

                queueTail = EnqueueIfLand(upGridRow, row - 1, column, queueRows, queueColumns, queueTail, ref totalValue);
            }

            if (row < m - 1)
            {
                var downGridRow = grid[row + 1];

                queueTail = EnqueueIfLand(downGridRow, row + 1, column, queueRows, queueColumns, queueTail, ref totalValue);
            }
        }

        return totalValue;
    }

    /// <summary>
    ///     Adds the given cell to the island total, floods it with water and enqueues it if it is land.
    /// </summary>
    /// <param name="gridRow">The row of the grid that contains the cell.</param>
    /// <param name="row">The row of the cell.</param>
    /// <param name="column">The column of the cell.</param>
    /// <param name="queueRows">The row indices of the queued cells.</param>
    /// <param name="queueColumns">The column indices of the queued cells.</param>
    /// <param name="queueTail">The index one past the last queued cell.</param>
    /// <param name="totalValue">The running total value of the island.</param>
    /// <returns>The index one past the last queued cell after the cell is processed.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int EnqueueIfLand(int[] gridRow, int row, int column, int[] queueRows, int[] queueColumns, int queueTail, ref long totalValue)
    {
        var value = gridRow[column];

        if (value == Water)
        {
            return queueTail;
        }

        totalValue += value;

        gridRow[column] = Water;

        queueRows[queueTail] = row;
        queueColumns[queueTail] = column;

        return queueTail + 1;
    }
}