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

namespace LeetCode.Algorithms.FindAllGroupOfFarmland;

/// <inheritdoc />
public sealed class FindAllGroupOfFarmlandBruteForce : IFindAllGroupOfFarmland
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(k), where k is the number of distinct rectangles found
    /// </remarks>
    public int[][] FindFarmland(int[][] land)
    {
        var result = new List<int[]>();

        for (var i = 0; i < land.Length; i++)
        {
            for (var j = 0; j < land[i].Length; j++)
            {
                if (land[i][j] != 1)
                {
                    continue;
                }

                FindFarmland(land, result, i, j, i, j);
            }
        }

        return [.. result];
    }

    private static void FindFarmland(int[][] land, List<int[]> result, int r1, int c1, int r2, int c2)
    {
        var extended = true;

        while (extended)
        {
            var canGoDown = r2 + 1 < land.Length && land[r2 + 1][c2] == 1;
            var canGoRight = c2 + 1 < land[r2].Length && land[r2][c2 + 1] == 1;

            if (canGoDown && canGoRight)
            {
                MarkAsVisited(land, r1, c1, r2 + 1, c2 + 1);

                r2 += 1;
                c2 += 1;
            }
            else if (canGoDown)
            {
                MarkAsVisited(land, r1, c1, r2 + 1, c2);

                r2 += 1;
            }
            else if (canGoRight)
            {
                MarkAsVisited(land, r1, c1, r2, c2 + 1);

                c2 += 1;
            }
            else
            {
                extended = false;
            }
        }

        result.Add([r1, c1, r2, c2]);
    }

    private static void MarkAsVisited(int[][] land, int r1, int c1, int r2, int c2)
    {
        for (var i = r1; i <= r2; i++)
        {
            for (var j = c1; j <= c2; j++)
            {
                land[i][j] = -1;
            }
        }
    }
}