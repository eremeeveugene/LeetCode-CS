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

namespace LeetCode.Algorithms.CircularSentence;

/// <summary>
///     https://leetcode.com/problems/circular-sentence/description/
/// </summary>
public interface ICircularSentence
{
    /// <summary>
    ///     Determines whether <paramref name="sentence" /> is circular, meaning the last character of each word is equal
    ///     to the first character of the next word, including wrapping from the last word to the first.
    /// </summary>
    /// <param name="sentence">The sentence consisting of space-separated words.</param>
    /// <returns><see langword="true" /> if <paramref name="sentence" /> is circular; otherwise, <see langword="false" />.</returns>
    bool IsCircularSentence(string sentence);
}