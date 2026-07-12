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

namespace LeetCode.Algorithms.MostCommonWord;

/// <summary>
///     https://leetcode.com/problems/most-common-word/description/
/// </summary>
public interface IMostCommonWord
{
    /// <summary>
    ///     Finds the most frequent word in <paramref name="paragraph" /> that is not present in
    ///     <paramref name="banned" />, ignoring case and punctuation.
    /// </summary>
    /// <param name="paragraph">The paragraph of text to search for the most common word.</param>
    /// <param name="banned">The list of words that must be excluded from consideration.</param>
    /// <returns>The most frequent non-banned word in <paramref name="paragraph" />, in lowercase.</returns>
    string MostCommonWord(string paragraph, string[] banned);
}