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

namespace LeetCode.Algorithms.LongestPalindromicSubstring;

/// <inheritdoc />
public class LongestPalindromicSubstringTwoPointers : ILongestPalindromicSubstring
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }

        var left = 0;
        var right = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var oddLength = ExpandAroundCenter(s, i, i);
            var evenLength = ExpandAroundCenter(s, i, i + 1);

            var maxLength = Math.Max(oddLength, evenLength);

            if (maxLength <= right - left)
            {
                continue;
            }

            left = i - ((maxLength - 1) / 2);
            right = i + (maxLength / 2);
        }

        return s.Substring(left, right - left + 1);
    }

    private static int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}