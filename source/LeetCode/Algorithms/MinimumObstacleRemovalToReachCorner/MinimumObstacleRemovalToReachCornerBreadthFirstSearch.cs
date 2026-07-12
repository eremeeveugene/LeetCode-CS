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
public sealed class MinimumObstacleRemovalToReachCornerBreadthFirstSearch : IMinimumObstacleRemovalToReachCorner
{
    private static readonly (int X, int Y)[] Directions = [(-1, 0), (1, 0), (0, -1), (0, 1)];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n), where m is the number of rows and n is the number of columns in the grid
    ///     Space complexity - O(m * n), where m is the number of rows and n is the number of columns in the grid
    /// </remarks>
    public int MinimumObstacles(int[][] grid)
    {
        var rowsCount = grid.Length;
        var columnsCount = grid[0].Length;

        var minimumObstacles = InitializeMinimumObstacles(rowsCount, columnsCount);

        var cellStatesLinkedList = new LinkedList<(int Row, int Column)>();

        cellStatesLinkedList.AddFirst((0, 0));

        while (cellStatesLinkedList.First != null)
        {
            var (row, column) = cellStatesLinkedList.First.Value;

            cellStatesLinkedList.RemoveFirst();

            foreach (var direction in Directions)
            {
                var nextRow = row + direction.X;
                var nextColumn = column + direction.Y;

                if (nextRow < 0 || nextRow >= rowsCount || nextColumn < 0 || nextColumn >= columnsCount)
                {
                    continue;
                }

                var nextObstaclesCount = minimumObstacles[row, column] + grid[nextRow][nextColumn];

                if (nextObstaclesCount >= minimumObstacles[nextRow, nextColumn])
                {
                    continue;
                }

                minimumObstacles[nextRow, nextColumn] = nextObstaclesCount;

                if (grid[nextRow][nextColumn] == 1)
                {
                    cellStatesLinkedList.AddLast((nextRow, nextColumn));
                }
                else
                {
                    cellStatesLinkedList.AddFirst((nextRow, nextColumn));
                }
            }
        }

        return minimumObstacles[rowsCount - 1, columnsCount - 1];
    }

    private static int[,] InitializeMinimumObstacles(int rowsCount, int columnsCount)
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
}