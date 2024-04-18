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

namespace LeetCode.Algorithms.IslandPerimeter;

/// <inheritdoc />
public class IslandPerimeterIterative : IIslandPerimeter
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int IslandPerimeter(int[][] grid)
    {
        var perimeter = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1)
                {
                    continue;
                }

                if (i - 1 < 0 || grid[i - 1][j] == 0)
                {
                    perimeter++;
                }

                if (i + 1 >= grid.Length || grid[i + 1][j] == 0)
                {
                    perimeter++;
                }

                if (j - 1 < 0 || grid[i][j - 1] == 0)
                {
                    perimeter++;
                }

                if (j + 1 >= grid[i].Length || grid[i][j + 1] == 0)
                {
                    perimeter++;
                }
            }
        }

        return perimeter;
    }
}