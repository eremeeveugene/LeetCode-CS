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
public sealed class CountSubmatricesWithAllOnesVerticalHeights : ICountSubmatricesWithAllOnes
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n^2)
    ///     Space complexity - (n)
    /// </remarks>
    public int NumSubmat(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var heights = new int[n];

        var result = 0;

        for (var i = 0; i < m; i++)
        {
            UpdateHeights(mat[i], heights);

            result += CountSubmatricesEndingAtRow(heights);
        }

        return result;
    }

    private static void UpdateHeights(int[] row, int[] heights)
    {
        for (var j = 0; j < heights.Length; j++)
        {
            heights[j] = row[j] == 0 ? 0 : heights[j] + 1;
        }
    }

    private static int CountSubmatricesEndingAtRow(int[] heights)
    {
        var result = 0;

        for (var j = 0; j < heights.Length; j++)
        {
            if (heights[j] == 0)
            {
                continue;
            }

            var minHeight = heights[j];

            for (var k = j; k >= 0 && minHeight > 0; k--)
            {
                minHeight = Math.Min(minHeight, heights[k]);

                if (minHeight == 0)
                {
                    break;
                }

                result += minHeight;
            }
        }

        return result;
    }
}