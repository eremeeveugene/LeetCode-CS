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

namespace LeetCode.Algorithms.SmallestPairWithDifferentFrequencies;

/// <summary>
///     https://leetcode.com/problems/smallest-pair-with-different-frequencies/description/
/// </summary>
public interface ISmallestPairWithDifferentFrequencies
{
    /// <summary>
    ///     Finds the lexicographically smallest pair of adjacent indices in <paramref name="nums" /> whose
    ///     elements have different frequencies of occurrence within the array.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>An array containing the two indices of the qualifying pair, or an empty array if none exists.</returns>
    int[] MinDistinctFreqPair(int[] nums);
}