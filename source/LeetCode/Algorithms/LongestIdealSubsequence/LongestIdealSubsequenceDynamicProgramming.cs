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

namespace LeetCode.Algorithms.LongestIdealSubsequence;

/// <inheritdoc />
public class LongestIdealSubsequenceDynamicProgramming : ILongestIdealSubsequence
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int LongestIdealString(string s, int k)
    {
        var dp = new int[26];
        var maxLength = 0;

        foreach (var ch in s)
        {
            var currentMaxLength = 1;

            for (var i = Math.Max('a', ch - k); i <= Math.Min('z', ch + k); i++)
            {
                var idx = i - 'a';

                currentMaxLength = Math.Max(currentMaxLength, dp[idx] + 1);
            }

            dp[ch - 'a'] = currentMaxLength;

            maxLength = Math.Max(maxLength, currentMaxLength);
        }

        return maxLength;
    }
}