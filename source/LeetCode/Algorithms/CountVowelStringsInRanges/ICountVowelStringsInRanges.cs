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

namespace LeetCode.Algorithms.CountVowelStringsInRanges;

/// <summary>
///     https://leetcode.com/problems/count-vowel-strings-in-ranges/description/
/// </summary>
public interface ICountVowelStringsInRanges
{
    /// <summary>
    ///     For each range in <paramref name="queries" />, counts the words in <paramref name="words" /> within that range
    ///     that both start and end with a vowel.
    /// </summary>
    /// <param name="words">The array of strings to examine.</param>
    /// <param name="queries">The array of [start, end] inclusive index ranges to query.</param>
    /// <returns>An array where each element is the count of vowel-bounded words for the corresponding query.</returns>
    int[] VowelStrings(string[] words, int[][] queries);
}