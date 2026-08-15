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

namespace LeetCode.Algorithms.MinimumNumberOfDaysToDisconnectIsland;

/// <inheritdoc />
public sealed class MinimumNumberOfDaysToDisconnectIslandBruteForceVisitedArray : IMinimumNumberOfDaysToDisconnectIsland
{
    private const int NoRemovedCell = -1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 * m^2)
    ///     Space complexity - O(n * m)
    /// </remarks>
    public int MinDays(int[][] grid)
    {
        if (GetIslandsCount(grid, NoRemovedCell, NoRemovedCell) != 1)
        {
            return 0;
        }

        for (var i = 0; i < grid.Length; i++)
        {
            var row = grid[i];

            for (var j = 0; j < row.Length; j++)
            {
                if (row[j] != 1)
                {
                    continue;
                }

                if (GetIslandsCount(grid, i, j) != 1)
                {
                    return 1;
                }
            }
        }

        return 2;
    }

    private static int GetIslandsCount(int[][] grid, int removedRow, int removedColumn)
    {
        var islandsCount = 0;

        var visited = new bool[grid.Length][];

        for (var i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1 || visited[i][j] || (i == removedRow && j == removedColumn))
                {
                    continue;
                }

                MarkAsVisited(grid, visited, i, j, removedRow, removedColumn);

                islandsCount++;
            }
        }

        return islandsCount;
    }

    private static void MarkAsVisited(int[][] grid, bool[][] visited, int i, int j, int removedRow, int removedColumn)
    {
        if (grid[i][j] == 0 || visited[i][j] || (i == removedRow && j == removedColumn))
        {
            return;
        }

        visited[i][j] = true;

        if (i - 1 >= 0)
        {
            MarkAsVisited(grid, visited, i - 1, j, removedRow, removedColumn);
        }

        if (i + 1 < grid.Length)
        {
            MarkAsVisited(grid, visited, i + 1, j, removedRow, removedColumn);
        }

        if (j - 1 >= 0)
        {
            MarkAsVisited(grid, visited, i, j - 1, removedRow, removedColumn);
        }

        if (j + 1 < grid[i].Length)
        {
            MarkAsVisited(grid, visited, i, j + 1, removedRow, removedColumn);
        }
    }
}