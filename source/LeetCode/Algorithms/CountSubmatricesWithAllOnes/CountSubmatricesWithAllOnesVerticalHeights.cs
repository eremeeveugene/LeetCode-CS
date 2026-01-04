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

namespace LeetCode.Algorithms.CountSubmatricesWithAllOnes;

/// <inheritdoc />
public class CountSubmatricesWithAllOnesVerticalHeights : ICountSubmatricesWithAllOnes
{
    /// <summary>
    ///     Time complexity - O(m * n^2)
    ///     Space complexity - (n)
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
    public int NumSubmat(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var heights = new int[n];

        var result = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (mat[i][j] == 0)
                {
                    heights[j] = 0;
                }
                else
                {
                    heights[j]++;
                }
            }

            for (var j = 0; j < n; j++)
            {
                if (heights[j] == 0)
                {
                    continue;
                }

                var minHeight = heights[j];

                for (var k = j; k >= 0 && minHeight > 0; k--)
                {
                    if (heights[k] < minHeight)
                    {
                        minHeight = heights[k];
                    }

                    if (minHeight == 0)
                    {
                        break;
                    }

                    result += minHeight;
                }
            }
        }

        return result;
    }
}