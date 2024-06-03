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

namespace LeetCode.Algorithms.NumberOfIslands;

/// <inheritdoc />
public class NumberOfIslandsIterative : INumberOfIslands
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(n * m)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int NumIslands(char[][] grid)
    {
        var num = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != '1')
                {
                    continue;
                }

                num++;

                Find(grid, i, j);
            }
        }

        return num;
    }

    private static void Find(IReadOnlyList<char[]> grid, int i, int j)
    {
        if (i + 1 < grid.Count && grid[i + 1][j] == '1')
        {
            grid[i + 1][j] = '2';

            Find(grid, i + 1, j);
        }

        if (i - 1 >= 0 && grid[i - 1][j] == '1')
        {
            grid[i - 1][j] = '2';

            Find(grid, i - 1, j);
        }

        if (j + 1 < grid[i].Length && grid[i][j + 1] == '1')
        {
            grid[i][j + 1] = '2';

            Find(grid, i, j + 1);
        }

        if (j - 1 >= 0 && grid[i][j - 1] == '1')
        {
            grid[i][j - 1] = '2';

            Find(grid, i, j - 1);
        }
    }
}