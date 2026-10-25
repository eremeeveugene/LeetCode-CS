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
public sealed class NumberOfClosedIslandsDepthFirstSearch : INumberOfClosedIslands
{
    private const int Land = 0;
    private const int Water = 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int ClosedIsland(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var closedIslandsCount = 0;

        for (var row = 0; row < m; row++)
        {
            for (var column = 0; column < n; column++)
            {
                if (grid[row][column] != Land)
                {
                    continue;
                }

                var isClosed = GetIsClosed(grid, m, n, row, column);

                if (isClosed)
                {
                    closedIslandsCount++;
                }
            }
        }

        return closedIslandsCount;
    }

    /// <summary>
    ///     Floods the unvisited land reachable from the given cell with water and checks whether that land is fully
    ///     surrounded by water.
    /// </summary>
    /// <param name="grid">The binary matrix where 0 is land and 1 is water.</param>
    /// <param name="m">The number of rows in <paramref name="grid" />.</param>
    /// <param name="n">The number of columns in <paramref name="grid" />.</param>
    /// <param name="row">The row of the cell to visit.</param>
    /// <param name="column">The column of the cell to visit.</param>
    /// <returns>
    ///     <see langword="true" /> if the land reachable from the given cell never runs off the grid; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </remarks>
    private static bool GetIsClosed(int[][] grid, int m, int n, int row, int column)
    {
        if (row < 0 || column < 0 || row >= m || column >= n)
        {
            return false;
        }

        if (grid[row][column] == Water)
        {
            return true;
        }

        grid[row][column] = Water;

        var isDownClosed = GetIsClosed(grid, m, n, row + 1, column);
        var isUpClosed = GetIsClosed(grid, m, n, row - 1, column);
        var isRightClosed = GetIsClosed(grid, m, n, row, column + 1);
        var isLeftClosed = GetIsClosed(grid, m, n, row, column - 1);

        return isDownClosed && isUpClosed && isRightClosed && isLeftClosed;
    }
}