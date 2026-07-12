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

namespace LeetCode.Algorithms.UncommonWordsFromTwoSentences;

/// <summary>
///     https://leetcode.com/problems/uncommon-words-from-two-sentences/description/
/// </summary>
public interface IUncommonWordsFromTwoSentences
{
    /// <summary>
    ///     Finds every word that appears exactly once across the combination of sentences <paramref name="s1" />
    ///     and <paramref name="s2" />, and does not appear in the other sentence.
    /// </summary>
    /// <param name="s1">The first sentence of space-separated words.</param>
    /// <param name="s2">The second sentence of space-separated words.</param>
    /// <returns>An array of the uncommon words found across both sentences.</returns>
    string[] UncommonFromSentences(string s1, string s2);
}