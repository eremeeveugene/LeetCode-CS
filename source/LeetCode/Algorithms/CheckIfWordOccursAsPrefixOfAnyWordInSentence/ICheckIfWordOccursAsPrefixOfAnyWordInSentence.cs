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

namespace LeetCode.Algorithms.CheckIfWordOccursAsPrefixOfAnyWordInSentence;

/// <summary>
///     https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/description/
/// </summary>
public interface ICheckIfWordOccursAsPrefixOfAnyWordInSentence
{
    /// <summary>
    ///     Finds the index of the first word in <paramref name="sentence" /> that has <paramref name="searchWord" /> as a
    ///     prefix.
    /// </summary>
    /// <param name="sentence">The sentence consisting of space-separated words.</param>
    /// <param name="searchWord">The word whose occurrence as a prefix is searched for.</param>
    /// <returns>
    ///     The 1-indexed position of the first word in <paramref name="sentence" /> that starts with
    ///     <paramref name="searchWord" />, or -1 if no such word exists.
    /// </returns>
    int IsPrefixOfWord(string sentence, string searchWord);
}