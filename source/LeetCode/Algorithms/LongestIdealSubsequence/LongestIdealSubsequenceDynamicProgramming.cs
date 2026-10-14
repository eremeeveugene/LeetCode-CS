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

namespace LeetCode.Algorithms.LongestIdealSubsequence;

/// <inheritdoc />
public sealed class LongestIdealSubsequenceDynamicProgramming : ILongestIdealSubsequence
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LongestIdealString(string s, int k)
    {
        var dp = new int[26];
        var maxLength = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            var currentMaxLength = 1;

            for (var j = Math.Max('a', ch - k); j <= Math.Min('z', ch + k); j++)
            {
                var idx = j - 'a';

                currentMaxLength = Math.Max(currentMaxLength, dp[idx] + 1);
            }

            dp[ch - 'a'] = currentMaxLength;

            maxLength = Math.Max(maxLength, currentMaxLength);
        }

        return maxLength;
    }
}