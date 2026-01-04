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

namespace LeetCode.Algorithms.LongestBinarySubsequenceLessThanOrEqualToK;

/// <inheritdoc />
public class LongestBinarySubsequenceLessThanOrEqualToKGreedy : ILongestBinarySubsequenceLessThanOrEqualToK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int LongestSubsequence(string s, int k)
    {
        var count = 0;
        var value = 0;
        var power = 1;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '1' && value + power <= k)
            {
                value += power;

                count++;
            }

            if (power > k / 2)
            {
                break;
            }

            power <<= 1;
        }

        return count + s.Count(c => c == '0');
    }
}