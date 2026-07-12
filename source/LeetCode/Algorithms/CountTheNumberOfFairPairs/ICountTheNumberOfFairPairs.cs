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

namespace LeetCode.Algorithms.CountTheNumberOfFairPairs;

/// <summary>
///     https://leetcode.com/problems/count-the-number-of-fair-pairs/description/
/// </summary>
public interface ICountTheNumberOfFairPairs
{
    /// <summary>
    ///     Counts the fair pairs of indices (i, j) with i &lt; j in <paramref name="nums" /> whose element sum lies within
    ///     the inclusive range [<paramref name="lower" />, <paramref name="upper" />].
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="lower">The inclusive lower bound of a qualifying pair's sum.</param>
    /// <param name="upper">The inclusive upper bound of a qualifying pair's sum.</param>
    /// <returns>The total number of fair pairs.</returns>
    long CountFairPairs(int[] nums, int lower, int upper);
}