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

namespace LeetCode.Algorithms.MergeStringsAlternately;

/// <summary>
///     https://leetcode.com/problems/merge-strings-alternately/description/
/// </summary>
public interface IMergeStringsAlternately
{
    /// <summary>
    ///     Merges <paramref name="word1" /> and <paramref name="word2" /> by alternating characters from each,
    ///     appending any remaining characters from the longer string at the end.
    /// </summary>
    /// <param name="word1">The first string to merge.</param>
    /// <param name="word2">The second string to merge.</param>
    /// <returns>The merged string.</returns>
    string MergeAlternately(string word1, string word2);
}