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

namespace LeetCode.Algorithms.MaximumAscendingSubarraySum;

/// <summary>
///     https://leetcode.com/problems/maximum-ascending-subarray-sum/description/
/// </summary>
public interface IMaximumAscendingSubarraySum
{
    /// <summary>
    ///     Finds the maximum sum of a strictly ascending contiguous subarray of <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of positive integers to search for an ascending subarray.</param>
    /// <returns>The maximum sum achievable by any strictly ascending contiguous subarray of <paramref name="nums" />.</returns>
    int MaxAscendingSum(int[] nums);
}