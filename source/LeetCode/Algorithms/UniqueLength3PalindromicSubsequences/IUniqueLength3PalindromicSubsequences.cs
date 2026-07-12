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

namespace LeetCode.Algorithms.UniqueLength3PalindromicSubsequences;

/// <summary>
///     https://leetcode.com/problems/unique-length-3-palindromic-subsequences/description/
/// </summary>
public interface IUniqueLength3PalindromicSubsequences
{
    /// <summary>
    ///     Counts the number of unique palindromic subsequences of length three that can be formed from
    ///     <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string to search for length-three palindromic subsequences in.</param>
    /// <returns>The number of unique length-three palindromic subsequences.</returns>
    int CountPalindromicSubsequence(string s);
}