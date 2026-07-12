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

namespace LeetCode.Algorithms.MaximumSumOfDistinctSubarraysWithLengthK;

/// <summary>
///     https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k/description/
/// </summary>
public interface IMaximumSumOfDistinctSubarraysWithLengthK
{
    /// <summary>
    ///     Finds the maximum sum among all subarrays of <paramref name="nums" /> with length <paramref name="k" />
    ///     whose elements are all distinct.
    /// </summary>
    /// <param name="nums">The array of integers to scan.</param>
    /// <param name="k">The required length of each subarray.</param>
    /// <returns>The maximum sum of a subarray of length <paramref name="k" /> with distinct elements, or 0 if none exists.</returns>
    long MaximumSubarraySum(int[] nums, int k);
}