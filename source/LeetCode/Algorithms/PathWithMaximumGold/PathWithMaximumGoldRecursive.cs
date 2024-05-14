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

namespace LeetCode.Algorithms.PathWithMaximumGold;

/// <inheritdoc />
public class PathWithMaximumGoldRecursive : IPathWithMaximumGold
{
    /// <summary>
    ///     Time complexity - O((m * n) * 4 ^ (m * n)
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int GetMaximumGold(int[][] grid)
    {
        var maxGold = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }

                maxGold = Math.Max(maxGold, GetMaximumGold(grid, i, j, 0));
            }
        }

        return maxGold;
    }

    private static int GetMaximumGold(IReadOnlyList<int[]> grid, int i, int j, int currentGold)
    {
        var cell = grid[i][j];

        currentGold += cell;

        grid[i][j] = 0;

        var maxGold = currentGold;

        if (i + 1 < grid.Count && grid[i + 1][j] != 0)
        {
            maxGold = Math.Max(maxGold, GetMaximumGold(grid, i + 1, j, currentGold));
        }

        if (i - 1 >= 0 && grid[i - 1][j] != 0)
        {
            maxGold = Math.Max(maxGold, GetMaximumGold(grid, i - 1, j, currentGold));
        }

        if (j + 1 < grid[i].Length && grid[i][j + 1] != 0)
        {
            maxGold = Math.Max(maxGold, GetMaximumGold(grid, i, j + 1, currentGold));
        }

        if (j - 1 >= 0 && grid[i][j - 1] != 0)
        {
            maxGold = Math.Max(maxGold, GetMaximumGold(grid, i, j - 1, currentGold));
        }

        grid[i][j] = cell;

        return maxGold;
    }
}