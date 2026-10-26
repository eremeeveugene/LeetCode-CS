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
public sealed class CountIslandsWithTotalValueDivisibleByKDepthFirstSearchStack : ICountIslandsWithTotalValueDivisibleByK
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

        var length = m * n;

        Span<int> stackRows = stackalloc int[length];
        Span<int> stackColumns = stackalloc int[length];

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

                var totalValue = GetTotalValue(grid, m, n, stackRows, stackColumns, i, j);

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
    /// <param name="stackRows">The buffer reused for the row indices of the stacked cells.</param>
    /// <param name="stackColumns">The buffer reused for the column indices of the stacked cells.</param>
    /// <param name="startRow">The row of the land cell to start from.</param>
    /// <param name="startColumn">The column of the land cell to start from.</param>
    /// <returns>The total value of the island.</returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static long GetTotalValue(int[][] grid, int m, int n, Span<int> stackRows, Span<int> stackColumns, int startRow, int startColumn)
    {
        var totalValue = 0L;

        var startGridRow = grid[startRow];

        var stackSize = PushIfLand(startGridRow, startRow, startColumn, stackRows, stackColumns, 0, ref totalValue);

        while (stackSize > 0)
        {
            stackSize--;

            var row = stackRows[stackSize];
            var column = stackColumns[stackSize];

            var gridRow = grid[row];

            if (column > 0)
            {
                stackSize = PushIfLand(gridRow, row, column - 1, stackRows, stackColumns, stackSize, ref totalValue);
            }

            if (column < n - 1)
            {
                stackSize = PushIfLand(gridRow, row, column + 1, stackRows, stackColumns, stackSize, ref totalValue);
            }

            if (row > 0)
            {
                var upGridRow = grid[row - 1];

                stackSize = PushIfLand(upGridRow, row - 1, column, stackRows, stackColumns, stackSize, ref totalValue);
            }

            if (row < m - 1)
            {
                var downGridRow = grid[row + 1];

                stackSize = PushIfLand(downGridRow, row + 1, column, stackRows, stackColumns, stackSize, ref totalValue);
            }
        }

        return totalValue;
    }

    /// <summary>
    ///     Adds the given cell to the island total, floods it with water and pushes it onto the stack if it is land.
    /// </summary>
    /// <param name="gridRow">The row of the grid that contains the cell.</param>
    /// <param name="row">The row of the cell.</param>
    /// <param name="column">The column of the cell.</param>
    /// <param name="stackRows">The row indices of the stacked cells.</param>
    /// <param name="stackColumns">The column indices of the stacked cells.</param>
    /// <param name="stackSize">The number of stacked cells.</param>
    /// <param name="totalValue">The running total value of the island.</param>
    /// <returns>The number of stacked cells after the cell is processed.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int PushIfLand(int[] gridRow, int row, int column, Span<int> stackRows, Span<int> stackColumns, int stackSize, ref long totalValue)
    {
        var value = gridRow[column];

        if (value == Water)
        {
            return stackSize;
        }

        totalValue += value;

        gridRow[column] = Water;

        stackRows[stackSize] = row;
        stackColumns[stackSize] = column;

        return stackSize + 1;
    }
}