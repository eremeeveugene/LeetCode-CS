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

namespace LeetCode.Algorithms.WaysToExpressAnIntegerAsSumOfPowers;

/// <inheritdoc />
public sealed class WaysToExpressAnIntegerAsSumOfPowersDynamicProgramming : IWaysToExpressAnIntegerAsSumOfPowers
{
    private const int Mod = 1_000_000_007;

    /// <summary>
    ///     Time complexity - O(n^(1 + 1/x))
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public int NumberOfWays(int n, int x)
    {
        var dp = new long[n + 1];

        dp[0] = 1;

        for (var i = 1; i <= n; i++)
        {
            var power = Pow(i, x);

            if (power > n)
            {
                break;
            }

            for (var j = n; j >= power; j--)
            {
                dp[j] = (dp[j] + dp[j - power]) % Mod;
            }
        }

        return (int)dp[n];
    }

    private static int Pow(int value, int exponent)
    {
        var result = 1;

        for (var i = 0; i < exponent; i++)
        {
            result *= value;
        }

        return result;
    }
}