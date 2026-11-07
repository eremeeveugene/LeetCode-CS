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

namespace LeetCode.Algorithms.MaximizeTheNumberOfPartitionsAfterOperations;

/// <summary>
///     https://leetcode.com/problems/maximize-the-number-of-partitions-after-operations/description/
/// </summary>
public interface IMaximizeTheNumberOfPartitionsAfterOperations
{
    /// <summary>
    ///     Finds the maximum number of partitions obtained by repeatedly removing the longest prefix containing at most
    ///     <paramref name="k" /> distinct characters, after optionally changing at most one character of
    ///     <paramref name="s" /> to another lowercase English letter.
    /// </summary>
    /// <param name="s">The string of lowercase English letters.</param>
    /// <param name="k">The maximum number of distinct characters allowed in each partition.</param>
    /// <returns>The maximum number of partitions after the optimal choice of at most one character change.</returns>
    int MaxPartitionsAfterOperations(string s, int k);
}