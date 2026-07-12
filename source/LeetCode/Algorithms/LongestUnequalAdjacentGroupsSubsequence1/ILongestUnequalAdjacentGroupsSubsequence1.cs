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

namespace LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence1;

/// <summary>
///     https://leetcode.com/problems/longest-unequal-adjacent-groups-subsequence-i/description/
/// </summary>
public interface ILongestUnequalAdjacentGroupsSubsequence1
{
    /// <summary>
    ///     Finds the longest subsequence of <paramref name="words" /> such that no two adjacent chosen words have the
    ///     same corresponding value in <paramref name="groups" />.
    /// </summary>
    /// <param name="words">The array of words to select a subsequence from.</param>
    /// <param name="groups">The array of group values, where <paramref name="groups" />[i] corresponds to <paramref name="words" />[i].</param>
    /// <returns>The longest subsequence of <paramref name="words" /> with no two adjacent elements sharing the same group.</returns>
    IList<string> GetLongestSubsequence(string[] words, int[] groups);
}