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

namespace LeetCode.Algorithms.RegionsCutBySlashes;

/// <inheritdoc />
public class RegionsCutBySlashesDepthFirstSearch : IRegionsCutBySlashes
{
    private const int Multiplier = 3;

    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public int RegionsBySlashes(string[] grid)
    {
        var matrix = new int[grid.Length * Multiplier][];

        for (var i = 0; i < grid.Length; i++)
        {
            var m = i * Multiplier;

            for (var j = 0; j < Multiplier; j++)
            {
                matrix[m + j] = new int[grid[i].Length * Multiplier];
            }

            for (var j = 0; j < grid[i].Length; j++)
            {
                var n = j * Multiplier;

                switch (grid[i][j])
                {
                    case '/':

                        for (var k = 0; k < Multiplier; k++)
                        {
                            matrix[m + k][n + (Multiplier - 1) - k] = 1;
                        }

                        break;
                    case '\\':
                        for (var k = 0; k < Multiplier; k++)
                        {
                            matrix[m + k][n + k] = 1;
                        }

                        break;
                }
            }
        }

        var regionCount = 0;

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    continue;
                }

                FindRegions(matrix, i, j);

                regionCount++;
            }
        }

        return regionCount;
    }

    private static void FindRegions(IReadOnlyList<int[]> matrix, int i, int j)
    {
        matrix[i][j] = -1;

        if (i + 1 < matrix.Count && matrix[i + 1][j] == 0)
        {
            FindRegions(matrix, i + 1, j);
        }

        if (i - 1 >= 0 && matrix[i - 1][j] == 0)
        {
            FindRegions(matrix, i - 1, j);
        }

        if (j + 1 < matrix[i].Length && matrix[i][j + 1] == 0)
        {
            FindRegions(matrix, i, j + 1);
        }

        if (j - 1 >= 0 && matrix[i][j - 1] == 0)
        {
            FindRegions(matrix, i, j - 1);
        }
    }
}