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

namespace LeetCode.Algorithms.MaximumNumberOfWordsFoundInSentences;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
/// </summary>
public interface IMaximumNumberOfWordsFoundInSentences
{
    /// <summary>
    ///     Finds the maximum number of words contained in any single sentence within <paramref name="sentences" />.
    /// </summary>
    /// <param name="sentences">The array of sentences, each a string of space-separated words.</param>
    /// <returns>The maximum word count found in any sentence of <paramref name="sentences" />.</returns>
    int MostWordsFound(string[] sentences);
}