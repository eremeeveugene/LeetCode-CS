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

namespace LeetCode.Algorithms.MinimumObstacleRemovalToReachCorner;

/// <inheritdoc />
public abstract class MinimumObstacleRemovalToReachCornerBase : IMinimumObstacleRemovalToReachCorner
{
    /// <inheritdoc />
    public abstract int MinimumObstacles(int[][] grid);

    /// <summary>
    ///     Creates the minimum obstacles counts for every cell: the top-left cell is <c>0</c> and every other cell is
    ///     <see cref="int.MaxValue" />.
    /// </summary>
    /// <param name="rowsCount">The number of rows in the grid.</param>
    /// <param name="columnsCount">The number of columns in the grid.</param>
    /// <returns>The initialized minimum obstacles counts.</returns>
    /// <remarks>
    ///     Time complexity - O(m * n), where m is the number of rows and n is the number of columns in the grid
    ///     Space complexity - O(m * n), where m is the number of rows and n is the number of columns in the grid
    /// </remarks>
    protected static int[,] InitializeMinimumObstacles(int rowsCount, int columnsCount)
    {
        var minimumObstacles = new int[rowsCount, columnsCount];

        for (var row = 0; row < rowsCount; row++)
        {
            for (var column = 0; column < columnsCount; column++)
            {
                minimumObstacles[row, column] = int.MaxValue;
            }
        }

        minimumObstacles[0, 0] = 0;

        return minimumObstacles;
    }

    /// <summary>
    ///     Relaxes the move from the cell at <paramref name="row" /> and <paramref name="column" /> to the cell at
    ///     <paramref name="nextRow" /> and <paramref name="nextColumn" />, recording the new minimum obstacles count of
    ///     the next cell when the move improves it.
    /// </summary>
    /// <param name="grid">The grid, where <c>1</c> is an obstacle and <c>0</c> is an empty cell.</param>
    /// <param name="minimumObstacles">The minimum obstacles counts found so far for each cell.</param>
    /// <param name="row">The row of the current cell.</param>
    /// <param name="column">The column of the current cell.</param>
    /// <param name="nextRow">The row of the next cell.</param>
    /// <param name="nextColumn">The column of the next cell.</param>
    /// <returns>
    ///     <see langword="true" /> if the next cell is inside the grid and its minimum obstacles count was improved;
    ///     otherwise, <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static bool TryRelax(int[][] grid, int[,] minimumObstacles, int row, int column, int nextRow, int nextColumn)
    {
        var rowsCount = grid.Length;
        var columnsCount = grid[0].Length;

        if (nextRow < 0 || nextRow >= rowsCount || nextColumn < 0 || nextColumn >= columnsCount)
        {
            return false;
        }

        var nextObstaclesCount = minimumObstacles[row, column] + grid[nextRow][nextColumn];

        if (nextObstaclesCount >= minimumObstacles[nextRow, nextColumn])
        {
            return false;
        }

        minimumObstacles[nextRow, nextColumn] = nextObstaclesCount;

        return true;
    }
}