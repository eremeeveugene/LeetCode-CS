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

namespace LeetCode.Algorithms.LongestPalindrome;

/// <inheritdoc />
public sealed class LongestPalindromeDictionary : ILongestPalindrome
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var charCount = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (!charCount.TryAdd(c, 1))
            {
                charCount[c]++;
            }
        }

        var length = 0;
        var oddCountFound = false;

        foreach (var count in charCount.Values)
        {
            if (count % 2 == 0)
            {
                length += count;
            }
            else
            {
                length += count - 1;
                oddCountFound = true;
            }
        }

        if (oddCountFound)
        {
            length++;
        }

        return length;
    }
}