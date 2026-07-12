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

namespace LeetCode.Algorithms.LongestPalindromicSubstring;

/// <summary>
///     https://leetcode.com/problems/longest-palindromic-substring/description/
/// </summary>
public interface ILongestPalindromicSubstring
{
    /// <summary>
    ///     Finds the longest contiguous substring of <paramref name="s" /> that reads the same forwards and backwards.
    /// </summary>
    /// <param name="s">The string to search for a palindromic substring.</param>
    /// <returns>The longest palindromic substring of <paramref name="s" />.</returns>
    string LongestPalindrome(string s);
}