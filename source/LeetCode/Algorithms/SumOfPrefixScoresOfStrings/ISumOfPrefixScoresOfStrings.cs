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

namespace LeetCode.Algorithms.SumOfPrefixScoresOfStrings;

/// <summary>
///     https://leetcode.com/problems/sum-of-prefix-scores-of-strings/
/// </summary>
public interface ISumOfPrefixScoresOfStrings
{
    /// <summary>
    ///     Computes, for each word in <paramref name="words" />, the sum of the counts of how many words in the
    ///     array share each of its prefixes.
    /// </summary>
    /// <param name="words">The array of strings to score.</param>
    /// <returns>An array where each element is the prefix score of the corresponding word in <paramref name="words" />.</returns>
    int[] SumPrefixScores(string[] words);
}