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

namespace LeetCode.Algorithms.StoneGame2;

/// <inheritdoc />
public class StoneGame2DynamicProgramming : IStoneGame2
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="piles"></param>
    /// <returns></returns>
    public int StoneGameII(int[] piles)
    {
        var n = piles.Length;

        var dp = new int[n][];

        for (var i = 0; i < n; i++)
        {
            dp[i] = new int[n + 1];
        }

        var suffixSum = new int[n];

        suffixSum[n - 1] = piles[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            suffixSum[i] = suffixSum[i + 1] + piles[i];
        }

        for (var i = n - 1; i >= 0; i--)
        {
            for (var m = 1; m <= n; m++)
            {
                if (i + (2 * m) >= n)
                {
                    dp[i][m] = suffixSum[i];
                }
                else
                {
                    for (var x = 1; x <= 2 * m; x++)
                    {
                        dp[i][m] = Math.Max(dp[i][m], suffixSum[i] - dp[i + x][Math.Max(m, x)]);
                    }
                }
            }
        }

        return dp[0][1];
    }
}