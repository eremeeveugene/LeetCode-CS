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

namespace LeetCode.Algorithms.CountingWordsWithGivenPrefix;

/// <summary>
///     https://leetcode.com/problems/counting-words-with-a-given-prefix/description/
/// </summary>
public interface ICountingWordsWithGivenPrefix
{
    /// <summary>
    ///     Counts the strings in <paramref name="words" /> that contain <paramref name="pref" /> as a prefix.
    /// </summary>
    /// <param name="words">The array of words.</param>
    /// <param name="pref">The prefix to search for.</param>
    /// <returns>The number of words that start with <paramref name="pref" />.</returns>
    int PrefixCount(string[] words, string pref);
}