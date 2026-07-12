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

namespace LeetCode.Algorithms.ValidPalindrome2;

/// <summary>
///     https://leetcode.com/problems/valid-palindrome-ii/
/// </summary>
public interface IValidPalindrome2
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> can be made into a palindrome by removing at most one
    ///     character.
    /// </summary>
    /// <param name="s">The string to check.</param>
    /// <returns><see langword="true" /> if <paramref name="s" /> can become a palindrome after removing at most one character; otherwise, <see langword="false" />.</returns>
    bool ValidPalindrome(string s);
}