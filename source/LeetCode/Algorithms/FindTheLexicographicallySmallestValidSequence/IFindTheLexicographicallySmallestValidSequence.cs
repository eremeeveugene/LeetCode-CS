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

namespace LeetCode.Algorithms.FindTheLexicographicallySmallestValidSequence;

/// <summary>
///     https://leetcode.com/problems/find-the-lexicographically-smallest-valid-sequence/description/
/// </summary>
public interface IFindTheLexicographicallySmallestValidSequence
{
    /// <summary>
    ///     Finds the lexicographically smallest strictly increasing sequence of indices into <paramref name="word1" />
    ///     whose characters, concatenated in order, form a string that is almost equal to <paramref name="word2" />
    ///     (differs from it in at most one position).
    /// </summary>
    /// <param name="word1">The string to select indices from.</param>
    /// <param name="word2">The target string the selected characters must almost equal.</param>
    /// <returns>
    ///     The lexicographically smallest valid sequence of indices, or an empty array if no valid sequence exists.
    /// </returns>
    int[] ValidSequence(string word1, string word2);
}