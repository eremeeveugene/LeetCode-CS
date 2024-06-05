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

namespace LeetCode.Algorithms.LongestPalindrome;

/// <inheritdoc />
public class LongestPalindromeDictionary : ILongestPalindrome
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var charCount = new Dictionary<char, int>();

        foreach (var c in s.Where(c => !charCount.TryAdd(c, 1)))
        {
            charCount[c]++;
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