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

namespace LeetCode.Algorithms.RangeSumOfSortedSubarraySums;

/// <summary>
///     https://leetcode.com/problems/range-sum-of-sorted-subarray-sums/
/// </summary>
public interface IRangeSumOfSortedSubarraySums
{
    /// <summary>
    ///     Computes the sum of the elements between indices <paramref name="left" /> and <paramref name="right" />
    ///     (1-indexed) in the sorted list of all subarray sums of <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers whose subarray sums are considered.</param>
    /// <param name="n">The number of elements in <paramref name="nums" />.</param>
    /// <param name="left">The 1-indexed lower bound of the range within the sorted subarray sums.</param>
    /// <param name="right">The 1-indexed upper bound of the range within the sorted subarray sums.</param>
    /// <returns>The sum of the sorted subarray sums between <paramref name="left" /> and <paramref name="right" />, modulo 10^9 + 7.</returns>
    int RangeSum(int[] nums, int n, int left, int right);
}