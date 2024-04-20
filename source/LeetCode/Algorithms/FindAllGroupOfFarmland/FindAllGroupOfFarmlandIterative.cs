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

namespace LeetCode.Algorithms.FindAllGroupOfFarmland;

/// <inheritdoc />
public class FindAllGroupOfFarmlandIterative : IFindAllGroupOfFarmland
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(k), where k is the number of distinct rectangles found
    /// </summary>
    /// <param name="land"></param>
    /// <returns></returns>
    public int[][] FindFarmland(int[][] land)
    {
        var result = new List<int[]>();

        for (var i = 0; i < land.Length; i++)
        {
            for (var j = 0; j < land[0].Length; j++)
            {
                if (land[i][j] == 1)
                {
                    result.Add(FindFarmlandCorner(land, i, j));
                }
            }
        }

        return [.. result];
    }

    private static int[] FindFarmlandCorner(IReadOnlyList<int[]> land, int x, int y)
    {
        var dx = x;
        var dy = y;

        while (dx < land.Count - 1 && land[dx + 1][dy] == 1)
        {
            dx++;
        }

        while (dy < land[0].Length - 1 && land[dx][dy + 1] == 1)
        {
            dy++;
        }

        for (var i = x; i <= dx; i++)
        {
            for (var j = y; j <= dy; j++)
            {
                land[i][j] = 0;
            }
        }

        return [x, y, dx, dy];
    }
}