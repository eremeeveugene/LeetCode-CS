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

namespace LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence2;

/// <summary>
///     https://leetcode.com/problems/longest-unequal-adjacent-groups-subsequence-ii/description/
/// </summary>
public interface ILongestUnequalAdjacentGroupsSubsequence2
{
    /// <summary>
    ///     Finds the longest subsequence of <paramref name="words" /> such that every two adjacent chosen words have
    ///     different corresponding values in <paramref name="groups" />, have equal lengths, and differ in exactly one
    ///     character.
    /// </summary>
    /// <param name="words">The array of distinct words to select a subsequence from.</param>
    /// <param name="groups">The array of group values, where <paramref name="groups" />[i] corresponds to <paramref name="words" />[i].</param>
    /// <returns>The longest subsequence of <paramref name="words" /> satisfying the adjacency conditions.</returns>
    IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups);
}