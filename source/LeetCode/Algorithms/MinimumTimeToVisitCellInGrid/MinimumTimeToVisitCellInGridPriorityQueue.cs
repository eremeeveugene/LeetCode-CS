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

namespace LeetCode.Algorithms.MinimumTimeToVisitCellInGrid;

/// <inheritdoc />
public class MinimumTimeToVisitCellInGridPriorityQueue : IMinimumTimeToVisitCellInGrid
{
    private static readonly IReadOnlyCollection<(int Row, int Column)> Directions = [(-1, 0), (1, 0), (0, -1), (0, 1)];

    /// <summary>
    ///     Time complexity - O(m * n log m *n)
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinimumTime(int[][] grid)
    {
        if (grid[0][1] > 1 && grid[1][0] > 1)
        {
            return -1;
        }

        var rowsCount = grid.Length;
        var columnsCount = grid[0].Length;

        var priorityQueue = new PriorityQueue<(int Row, int Column, int Time), int>();

        priorityQueue.Enqueue((0, 0, 0), 0);

        var seen = new bool[rowsCount, columnsCount];

        seen[0, 0] = true;

        while (priorityQueue.Count > 0)
        {
            var (row, column, time) = priorityQueue.Dequeue();

            foreach (var direction in Directions)
            {
                var targetRow = row + direction.Row;
                var targetColumn = column + direction.Column;

                if (targetRow < 0 ||
                    targetRow >= rowsCount ||
                    targetColumn < 0 ||
                    targetColumn >= columnsCount ||
                    seen[targetRow, targetColumn])
                {
                    continue;
                }

                var targetTime = time + 1;

                if (grid[targetRow][targetColumn] > targetTime)
                {
                    var waitTime = 0;

                    if ((grid[targetRow][targetColumn] - targetTime) % 2 != 0)
                    {
                        waitTime = 1;
                    }

                    targetTime = grid[targetRow][targetColumn] + waitTime;
                }

                if (targetRow == rowsCount - 1 && targetColumn == columnsCount - 1)
                {
                    return targetTime;
                }

                seen[targetRow, targetColumn] = true;

                priorityQueue.Enqueue((targetRow, targetColumn, targetTime), targetTime);
            }
        }

        return -1;
    }
}