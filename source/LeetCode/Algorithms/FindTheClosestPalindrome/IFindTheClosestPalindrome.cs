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

namespace LeetCode.Algorithms.FindTheClosestPalindrome;

/// <summary>
///     https://leetcode.com/problems/find-the-closest-palindrome/description/
/// </summary>
public interface IFindTheClosestPalindrome
{
    /// <summary>
    ///     Finds the closest palindrome to <paramref name="n" />, excluding <paramref name="n" /> itself; if there is a tie,
    ///     returns the smaller one.
    /// </summary>
    /// <param name="n">The string representation of an integer.</param>
    /// <returns>The string representation of the closest palindrome that is not equal to <paramref name="n" />.</returns>
    string NearestPalindromic(string n);
}