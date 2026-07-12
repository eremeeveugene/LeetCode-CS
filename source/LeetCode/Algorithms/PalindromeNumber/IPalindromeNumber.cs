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

namespace LeetCode.Algorithms.PalindromeNumber;

/// <summary>
///     https://leetcode.com/problems/palindrome-number/
/// </summary>
public interface IPalindromeNumber
{
    /// <summary>
    ///     Determines whether <paramref name="x" /> reads the same forwards and backwards when its digits are
    ///     considered as a sequence.
    /// </summary>
    /// <param name="x">The integer to check for being a palindrome.</param>
    /// <returns><see langword="true" /> if <paramref name="x" /> is a palindrome; otherwise, <see langword="false" />.</returns>
    bool IsPalindrome(int x);
}