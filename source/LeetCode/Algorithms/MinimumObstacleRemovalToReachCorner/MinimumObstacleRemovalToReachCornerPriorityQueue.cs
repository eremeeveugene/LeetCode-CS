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
public sealed class MinimumObstacleRemovalToReachCornerPriorityQueue : MinimumObstacleRemovalToReachCornerBase
{
    private static readonly (int X, int Y)[] Directions = [(-1, 0), (1, 0), (0, -1), (0, 1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n * log(m * n)), where m is the number of rows and n is the number of columns in the grid
    ///     Space complexity - O(m * n), where m is the number of rows and n is the number of columns in the grid
    /// </remarks>
    public override int MinimumObstacles(int[][] grid)
    {
        var rowsCount = grid.Length;
        var columnsCount = grid[0].Length;

        var minimumObstacles = InitializeMinimumObstacles(rowsCount, columnsCount);

        var cellStatesPriorityQueue = new PriorityQueue<(int Row, int Column), int>();

        cellStatesPriorityQueue.Enqueue((0, 0), 0);

        while (cellStatesPriorityQueue.Count > 0)
        {
            var (row, column) = cellStatesPriorityQueue.Dequeue();

            if (row == rowsCount - 1 && column == columnsCount - 1)
            {
                break;
            }

            for (var i = 0; i < Directions.Length; i++)
            {
                var direction = Directions[i];

                var nextRow = row + direction.X;
                var nextColumn = column + direction.Y;

                if (!TryRelax(grid, minimumObstacles, row, column, nextRow, nextColumn))
                {
                    continue;
                }

                var nextObstaclesCount = minimumObstacles[nextRow, nextColumn];

                cellStatesPriorityQueue.Enqueue((nextRow, nextColumn), nextObstaclesCount);
            }
        }

        return minimumObstacles[rowsCount - 1, columnsCount - 1];
    }
}