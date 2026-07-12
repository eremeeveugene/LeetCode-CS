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

namespace LeetCode.Algorithms.CountPairsWhoseSumIsLessThanTarget;

/// <summary>
///     https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/
/// </summary>
public interface ICountPairsWhoseSumIsLessThanTarget
{
    /// <summary>
    ///     Counts the pairs of indices (i, j) with i &lt; j in <paramref name="nums" /> whose element sum is strictly
    ///     less than <paramref name="target" />.
    /// </summary>
    /// <param name="nums">The list of integers to examine.</param>
    /// <param name="target">The value that a qualifying pair's sum must be less than.</param>
    /// <returns>The total number of pairs whose sum is less than <paramref name="target" />.</returns>
    int CountPairs(IList<int> nums, int target);
}