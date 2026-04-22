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

namespace LeetCode.Algorithms.WordsWithinTwoEditsOfDictionary;

/// <summary>
///     https://leetcode.com/problems/words-within-two-edits-of-dictionary/description/
/// </summary>
public interface IWordsWithinTwoEditsOfDictionary
{
    /// <summary>
    ///     Returns all strings from <paramref name="queries" /> that can be transformed
    ///     into at least one word in <paramref name="words" /> by changing at most two
    ///     characters (at any positions). All strings in both arrays have equal length.
    /// </summary>
    /// <param name="queries">Candidate strings to check against the dictionary.</param>
    /// <param name="words">Dictionary of target words of the same length as queries.</param>
    /// <returns>
    ///     The subset of <paramref name="queries" /> whose Hamming distance to some word
    ///     in <paramref name="words" /> is at most 2, preserved in original order.
    /// </returns>
    IList<string> TwoEditWords(string[] queries, string[] words);
}