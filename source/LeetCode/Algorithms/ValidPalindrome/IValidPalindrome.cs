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

namespace LeetCode.Algorithms.ValidPalindrome;

/// <summary>
///     https://leetcode.com/problems/valid-palindrome/description/
/// </summary>
public interface IValidPalindrome
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> is a palindrome after converting all uppercase letters to
    ///     lowercase and removing all non-alphanumeric characters.
    /// </summary>
    /// <param name="s">The string to check.</param>
    /// <returns><see langword="true" /> if the cleaned string is a palindrome; otherwise, <see langword="false" />.</returns>
    bool IsPalindrome(string s);
}