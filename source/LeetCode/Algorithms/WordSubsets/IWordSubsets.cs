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

namespace LeetCode.Algorithms.WordSubsets;

/// <summary>
///     https://leetcode.com/problems/word-subsets/description/
/// </summary>
public interface IWordSubsets
{
    /// <summary>
    ///     Finds every word in <paramref name="words1" /> that is universal — containing, for each word in
    ///     <paramref name="words2" />, at least as many occurrences of every letter as that word requires.
    /// </summary>
    /// <param name="words1">The array of candidate words to filter.</param>
    /// <param name="words2">The array of words whose letter requirements each candidate must satisfy.</param>
    /// <returns>A list of the universal words from <paramref name="words1" />.</returns>
    IList<string> WordSubsets(string[] words1, string[] words2);
}