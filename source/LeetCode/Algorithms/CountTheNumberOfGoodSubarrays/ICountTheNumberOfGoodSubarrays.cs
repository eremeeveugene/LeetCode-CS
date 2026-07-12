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

namespace LeetCode.Algorithms.CountTheNumberOfGoodSubarrays;

/// <summary>
///     https://leetcode.com/problems/count-the-number-of-good-subarrays/description/
/// </summary>
public interface ICountTheNumberOfGoodSubarrays
{
    /// <summary>
    ///     Counts the good subarrays of <paramref name="nums" />, defined as subarrays containing at least
    ///     <paramref name="k" /> pairs of equal elements (i, j) with i &lt; j.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="k">The minimum number of equal-value pairs required for a subarray to be good.</param>
    /// <returns>The total number of good subarrays.</returns>
    long CountGood(int[] nums, int k);
}