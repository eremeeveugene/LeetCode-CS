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
public class CountSubmatricesWithAllOnesHorizontalWidths : ICountSubmatricesWithAllOnes
{
    /// <summary>
    ///     Time complexity - O(m^2 * n)
    ///     Space complexity - (m * n)
    /// </summary>
    /// <param name="mat"></param>
    /// <returns></returns>
    public int NumSubmat(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var dp = new int[m, n];

        var result = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (mat[i][j] == 0)
                {
                    continue;
                }

                if (j == 0)
                {
                    dp[i, j]++;
                }
                else
                {
                    dp[i, j] = dp[i, j - 1] + 1;
                }


                var minWidth = dp[i, j];

                for (var k = i; k >= 0 && dp[k, j] > 0; k--)
                {
                    minWidth = Math.Min(minWidth, dp[k, j]);

                    result += minWidth;
                }
            }
        }

        return result;
    }
}