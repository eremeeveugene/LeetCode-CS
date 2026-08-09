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

namespace LeetCode.Algorithms.FreedomTrail;

/// <inheritdoc />
public sealed class FreedomTrailDynamicProgramming : IFreedomTrail
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m * n^2)
    ///     Space complexity - O(m * n)
    /// </remarks>
    public int FindRotateSteps(string ring, string key)
    {
        var n = ring.Length;
        var m = key.Length;

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

                dp[i, j] = GetMinRotateSteps(dp, n, i, j);
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

    private static int GetMinRotateSteps(int[,] dp, int n, int i, int j)
    {
        var result = int.MaxValue;

        for (var k = 0; k < n; k++)
        {
            if (dp[i - 1, k] == int.MaxValue)
            {
                continue;
            }

            var steps = Math.Min((j - k + n) % n, (k - j + n) % n);

            result = Math.Min(result, dp[i - 1, k] + steps + 1);
        }

        return result;
    }
}