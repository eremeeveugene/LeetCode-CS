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

namespace LeetCode.Algorithms.SortingTheSentence;

/// <summary>
///     https://leetcode.com/problems/sorting-the-sentence/description/
/// </summary>
public interface ISortingTheSentence
{
    /// <summary>
    ///     Reconstructs the original sentence from <paramref name="s" />, in which each word is suffixed with
    ///     its 1-indexed position in the sentence.
    /// </summary>
    /// <param name="s">The shuffled sentence with position-suffixed words.</param>
    /// <returns>The original sentence with words restored to their correct order.</returns>
    string SortSentence(string s);
}