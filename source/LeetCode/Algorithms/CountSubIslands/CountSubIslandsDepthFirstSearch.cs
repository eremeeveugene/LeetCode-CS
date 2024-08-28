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

namespace LeetCode.Algorithms.CountSubIslands;

/// <inheritdoc />
public class CountSubIslandsDepthFirstSearch : ICountSubIslands
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="grid1"></param>
    /// <param name="grid2"></param>
    /// <returns></returns>
    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        var count = 0;

        for (var i = 0; i < grid1.Length; i++)
        {
            for (var j = 0; j < grid1[i].Length; j++)
            {
                if (grid2[i][j] != 1 || grid1[i][j] != 1)
                {
                    continue;
                }

                if (GetIsSubIsland(grid1, grid2, i, j))
                {
                    count++;
                }
            }
        }

        return count;
    }

    private static bool GetIsSubIsland(int[][] grid1, int[][] grid2, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid1.Length || j >= grid1[i].Length || grid2[i][j] == 0)
        {
            return true;
        }

        grid2[i][j] = 0;

        var isSubIsland = grid1[i][j] == 1;

        isSubIsland &= GetIsSubIsland(grid1, grid2, i + 1, j);
        isSubIsland &= GetIsSubIsland(grid1, grid2, i - 1, j);
        isSubIsland &= GetIsSubIsland(grid1, grid2, i, j + 1);
        isSubIsland &= GetIsSubIsland(grid1, grid2, i, j - 1);

        return isSubIsland;
    }
}