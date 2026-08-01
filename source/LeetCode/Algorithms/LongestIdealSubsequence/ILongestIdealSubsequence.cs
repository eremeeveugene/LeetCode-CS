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

namespace LeetCode.Algorithms.LongestIdealSubsequence;

/// <summary>
///     https://leetcode.com/problems/longest-ideal-subsequence/
/// </summary>
public interface ILongestIdealSubsequence
{
    /// <summary>
    ///     Finds the length of the longest ideal subsequence of <paramref name="s" />, where consecutive letters in the subsequence differ in alphabet
    ///     position by at most <paramref name="k" />.
    /// </summary>
    /// <param name="s">The string of lowercase letters to select a subsequence from.</param>
    /// <param name="k">The maximum allowed absolute difference between the alphabet positions of consecutive letters.</param>
    /// <returns>The length of the longest ideal subsequence.</returns>
    int LongestIdealString(string s, int k);
}