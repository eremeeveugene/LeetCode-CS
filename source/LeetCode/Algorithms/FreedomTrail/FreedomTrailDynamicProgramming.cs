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

namespace LeetCode.Algorithms.FreedomTrail;

/// <inheritdoc />
public class FreedomTrailDynamicProgramming : IFreedomTrail
{
    /// <summary>
    ///     Time complexity - O(m * n^2)
    ///     Space complexity - O(m * n)
    /// </summary>
    /// <param name="ring"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public int FindRotateSteps(string ring, string key)
    {
        int n = ring.Length, m = key.Length;

        var dp = new int[m + 1, n];

        for (var i = 0; i <= m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }

        dp[0, 0] = 0;

        for (var i = 1; i <= m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (ring[j] != key[i - 1])
                {
                    continue;
                }

                for (var k = 0; k < n; k++)
                {
                    if (dp[i - 1, k] == int.MaxValue)
                    {
                        continue;
                    }

                    var steps = Math.Min((j - k + n) % n, (k - j + n) % n);
                    dp[i, j] = Math.Min(dp[i, j], dp[i - 1, k] + steps + 1);
                }
            }
        }

        var minSteps = int.MaxValue;

        for (var j = 0; j < n; j++)
        {
            if (ring[j] == key[m - 1])
            {
                minSteps = Math.Min(minSteps, dp[m, j]);
            }
        }

        return minSteps;
    }
}