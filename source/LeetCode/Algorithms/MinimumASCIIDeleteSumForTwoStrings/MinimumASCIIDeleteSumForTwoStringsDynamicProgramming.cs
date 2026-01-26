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

namespace LeetCode.Algorithms.MinimumASCIIDeleteSumForTwoStrings;

/// <inheritdoc />
public sealed class MinimumASCIIDeleteSumForTwoStringsDynamicProgramming : IMinimumASCIIDeleteSumForTwoStrings
{
    /// <summary>
    ///     Time complexity - O(n * m)
    ///     Space complexity - O(min(n, m))
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public int MinimumDeleteSum(string s1, string s2)
    {
        if (s1.Length < s2.Length)
        {
            (s1, s2) = (s2, s1);
        }

        Span<int> dp = stackalloc int[s2.Length + 1];

        for (var i = 0; i < s1.Length; i++)
        {
            var previous = 0;

            for (var j = 0; j < s2.Length; j++)
            {
                var current = dp[j + 1];

                if (s1[i] == s2[j])
                {
                    dp[j + 1] = previous + s1[i];
                }
                else if (dp[j + 1] <= dp[j])
                {
                    dp[j + 1] = dp[j];
                }

                previous = current;
            }
        }

        var totalAscii = 0;

        foreach (var c in s1)
        {
            totalAscii += c;
        }

        foreach (var c in s2)
        {
            totalAscii += c;
        }

        return totalAscii - (2 * dp[^1]);
    }
}