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

namespace LeetCode.Algorithms.OnesAndZeroes;

/// <inheritdoc />
public class OnesAndZeroesDynamicProgramming : IOnesAndZeroes
{
    /// <summary>
    ///     Time complexity - O(l * m * n), where l is the length of strs
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="strs"></param>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int FindMaxForm(string[] strs, int m, int n)
    {
        Span<int> dp = stackalloc int[(m + 1) * (n + 1)];

        foreach (var str in strs)
        {
            var zeros = 0;
            var ones = 0;

            foreach (var c in str)
            {
                if (c == '0')
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }
            }

            for (var i = m; i >= zeros; i--)
            {
                for (var j = n; j >= ones; j--)
                {
                    var index = GetIndex(i, j, n);
                    var previousIndex = GetIndex(i - zeros, j - ones, n);

                    dp[index] = Math.Max(dp[index], dp[previousIndex] + 1);
                }
            }
        }

        return dp[GetIndex(m, n, n)];
    }

    private static int GetIndex(int i, int j, int n)
    {
        return (i * (n + 1)) + j;
    }
}