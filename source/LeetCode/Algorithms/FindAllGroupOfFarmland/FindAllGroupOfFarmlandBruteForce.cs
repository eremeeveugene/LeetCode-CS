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
public class FindAllGroupOfFarmlandBruteForce : IFindAllGroupOfFarmland
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

    private static void FindFarmland(IReadOnlyList<int[]> land, ICollection<int[]> result, int r1, int c1, int r2,
        int c2)
    {
        while (true)
        {
            if (r2 + 1 < land.Count && land[r2 + 1][c2] == 1 && c2 + 1 < land[r2].Length && land[r2][c2 + 1] == 1)
            {
                MarkAsVisited(land, r1, c1, r2 + 1, c2 + 1);

                r2 += 1;
                c2 += 1;

                continue;
            }

            if (r2 + 1 < land.Count && land[r2 + 1][c2] == 1)
            {
                MarkAsVisited(land, r1, c1, r2 + 1, c2);

                r2 += 1;

                continue;
            }

            if (c2 + 1 < land[r2].Length && land[r2][c2 + 1] == 1)
            {
                MarkAsVisited(land, r1, c1, r2, c2 + 1);

                c2 += 1;

                continue;
            }

            result.Add([r1, c1, r2, c2]);

            break;
        }
    }

    private static void MarkAsVisited(IReadOnlyList<int[]> land, int r1, int c1, int r2, int c2)
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