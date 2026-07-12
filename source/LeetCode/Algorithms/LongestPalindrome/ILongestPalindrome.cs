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

/// <summary>
///     https://leetcode.com/problems/longest-palindrome/
/// </summary>
public interface ILongestPalindrome
{
    /// <summary>
    ///     Computes the length of the longest palindrome that can be built using the characters of <paramref name="s" />, using each character at most as many times as it occurs.
    /// </summary>
    /// <param name="s">The string whose characters are used to build a palindrome.</param>
    /// <returns>The length of the longest palindrome that can be built.</returns>
    int LongestPalindrome(string s);
}