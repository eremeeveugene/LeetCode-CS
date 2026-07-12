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

namespace LeetCode.Algorithms.SubarraySumsDivisibleByK;

/// <summary>
///     https://leetcode.com/problems/subarray-sums-divisible-by-k/
/// </summary>
public interface ISubarraySumsDivisibleByK
{
    /// <summary>
    ///     Counts the contiguous subarrays of <paramref name="nums" /> whose sum of elements is divisible by
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <param name="k">The divisor that a qualifying subarray's sum must be divisible by.</param>
    /// <returns>The number of contiguous subarrays of <paramref name="nums" /> whose sum is divisible by <paramref name="k" />.</returns>
    int SubarraysDivByK(int[] nums, int k);
}