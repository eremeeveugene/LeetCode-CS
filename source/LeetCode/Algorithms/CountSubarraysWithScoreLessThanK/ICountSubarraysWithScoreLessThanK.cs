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

namespace LeetCode.Algorithms.CountSubarraysWithScoreLessThanK;

/// <summary>
///     https://leetcode.com/problems/count-subarrays-with-score-less-than-k/description/
/// </summary>
public interface ICountSubarraysWithScoreLessThanK
{
    /// <summary>
    ///     Counts the non-empty subarrays of <paramref name="nums" /> whose score, defined as the subarray sum
    ///     multiplied by the subarray length, is strictly less than <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of positive integers to examine.</param>
    /// <param name="k">The exclusive upper bound for the subarray score.</param>
    /// <returns>The number of subarrays whose score is strictly less than <paramref name="k" />.</returns>
    long CountSubarrays(int[] nums, long k);
}