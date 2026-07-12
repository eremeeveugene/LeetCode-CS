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

namespace LeetCode.Algorithms.CountPrefixAndSuffixPairs1;

/// <summary>
///     https://leetcode.com/problems/count-prefix-and-suffix-pairs-i/
/// </summary>
public interface ICountPrefixAndSuffixPairs1
{
    /// <summary>
    ///     Counts the index pairs (i, j) with i &lt; j such that <paramref name="words" />[i] is both a prefix and a
    ///     suffix of <paramref name="words" />[j].
    /// </summary>
    /// <param name="words">The array of words to examine.</param>
    /// <returns>The number of prefix and suffix pairs.</returns>
    int CountPrefixSuffixPairs(string[] words);
}