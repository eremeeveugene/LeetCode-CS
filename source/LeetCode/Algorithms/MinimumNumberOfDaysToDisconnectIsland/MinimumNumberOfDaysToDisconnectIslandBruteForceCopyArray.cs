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
public class MinimumNumberOfDaysToDisconnectIslandBruteForceCopyArray : IMinimumNumberOfDaysToDisconnectIsland
{
    /// <summary>
    ///     Time complexity - O(n^2 * m^2)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int MinDays(int[][] grid)
    {
        if (GetIslandsCount(GetArrayCopy(grid)) != 1)
        {
            return 0;
        }

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1)
                {
                    continue;
                }

                var newGrid = GetArrayCopy(grid);

                newGrid[i][j] = 0;

                if (GetIslandsCount(newGrid) != 1)
                {
                    return 1;
                }
            }
        }

        return 2;
    }

    private static int[][] GetArrayCopy(IReadOnlyList<int[]> array)
    {
        var newArray = new int[array.Count][];

        for (var i = 0; i < array.Count; i++)
        {
            newArray[i] = new int[array[i].Length];

            for (var j = 0; j < array[i].Length; j++)
            {
                newArray[i][j] = array[i][j];
            }
        }

        return newArray;
    }

    private static int GetIslandsCount(IReadOnlyList<int[]> grid)
    {
        var islandsCount = 0;

        for (var i = 0; i < grid.Count; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1)
                {
                    continue;
                }

                MarkAsVisited(grid, i, j);

                islandsCount++;
            }
        }

        return islandsCount;
    }

    private static void MarkAsVisited(IReadOnlyList<int[]> grid, int i, int j)
    {
        if (grid[i][j] != 1)
        {
            return;
        }

        grid[i][j] = -1;

        if (i - 1 >= 0)
        {
            MarkAsVisited(grid, i - 1, j);
        }

        if (i + 1 < grid.Count)
        {
            MarkAsVisited(grid, i + 1, j);
        }

        if (j - 1 >= 0)
        {
            MarkAsVisited(grid, i, j - 1);
        }

        if (j + 1 < grid[i].Length)
        {
            MarkAsVisited(grid, i, j + 1);
        }
    }
}