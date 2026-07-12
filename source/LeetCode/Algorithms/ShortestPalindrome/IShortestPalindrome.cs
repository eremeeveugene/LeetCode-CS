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

namespace LeetCode.Algorithms.ShortestPalindrome;

/// <summary>
///     https://leetcode.com/problems/shortest-palindrome/
/// </summary>
public interface IShortestPalindrome
{
    /// <summary>
    ///     Converts <paramref name="s" /> into a palindrome by adding the fewest characters possible in front
    ///     of it.
    /// </summary>
    /// <param name="s">The string to convert into a palindrome.</param>
    /// <returns>The shortest palindrome that can be formed by prepending characters to <paramref name="s" />.</returns>
    string ShortestPalindrome(string s);
}