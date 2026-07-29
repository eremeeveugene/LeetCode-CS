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

namespace LeetCode.Algorithms.SmallestPalindromicRearrangement1;

/// <summary>
///     https://leetcode.com/problems/smallest-palindromic-rearrangement-i/description/
/// </summary>
public interface ISmallestPalindromicRearrangement1
{
    /// <summary>
    ///     Rearranges the characters of the palindromic string <paramref name="s" /> into the lexicographically smallest
    ///     palindromic permutation of its characters.
    /// </summary>
    /// <param name="s">The palindromic string to rearrange.</param>
    /// <returns>The lexicographically smallest palindromic permutation of <paramref name="s" />.</returns>
    string SmallestPalindrome(string s);
}