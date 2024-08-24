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

namespace LeetCode.Algorithms.StrangePrinter;

/// <inheritdoc />
public class StrangePrinterDynamicProgramming : IStrangePrinter
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n^2)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int StrangePrinter(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }

        var dp = new int[s.Length, s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            dp[i, i] = 1;
        }

        for (var length = 2; length <= s.Length; length++)
        {
            for (var i = 0; i <= s.Length - length; i++)
            {
                var j = i + length - 1;

                dp[i, j] = dp[i, j - 1] + 1;

                for (var k = i; k < j; k++)
                {
                    if (s[k] == s[j])
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k + 1, j - 1]);
                    }
                }
            }
        }

        return dp[0, s.Length - 1];
    }
}