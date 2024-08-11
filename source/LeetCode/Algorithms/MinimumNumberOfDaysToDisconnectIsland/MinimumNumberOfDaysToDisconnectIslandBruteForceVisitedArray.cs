// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MinimumNumberOfDaysToDisconnectIslandBruteForceVisitedArray : IMinimumNumberOfDaysToDisconnectIsland
{
    /// <summary>
    ///     Time complexity - O(n^2 * m^2)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinDays(int[][] grid)
    {
        if (GetIslandsCount(grid) != 1)
        {
            return 0;
        }

        foreach (var row in grid)
        {
            for (var j = 0; j < row.Length; j++)
            {
                if (row[j] != 1)
                {
                    continue;
                }

                row[j] = 0;

                if (GetIslandsCount(grid) != 1)
                {
                    return 1;
                }

                row[j] = 1;
            }
        }

        return 2;
    }

    private static int GetIslandsCount(IReadOnlyList<int[]> grid)
    {
        var islandsCount = 0;

        var visited = new bool[grid.Count][];

        for (var i = 0; i < grid.Count; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }

        for (var i = 0; i < grid.Count; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1 || visited[i][j])
                {
                    continue;
                }

                MarkAsVisited(grid, visited, i, j);

                islandsCount++;
            }
        }

        return islandsCount;
    }

    private static void MarkAsVisited(IReadOnlyList<int[]> grid, IReadOnlyList<bool[]> visited, int i, int j)
    {
        if (grid[i][j] == 0 || visited[i][j])
        {
            return;
        }

        visited[i][j] = true;

        if (i - 1 >= 0)
        {
            MarkAsVisited(grid, visited, i - 1, j);
        }

        if (i + 1 < grid.Count)
        {
            MarkAsVisited(grid, visited, i + 1, j);
        }

        if (j - 1 >= 0)
        {
            MarkAsVisited(grid, visited, i, j - 1);
        }

        if (j + 1 < grid[i].Length)
        {
            MarkAsVisited(grid, visited, i, j + 1);
        }
    }
}