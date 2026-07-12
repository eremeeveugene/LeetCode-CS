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

namespace LeetCode.Algorithms.MaximumUniqueSubarraySumAfterDeletion;

/// <summary>
///     https://leetcode.com/problems/maximum-unique-subarray-sum-after-deletion/description/
/// </summary>
public interface IMaximumUniqueSubarraySumAfterDeletion
{
    /// <summary>
    ///     Finds the maximum sum of a subarray of <paramref name="nums" /> after removing duplicate values so that
    ///     the remaining elements considered are all unique.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <returns>The maximum possible sum of a subarray with unique elements.</returns>
    int MaxSum(int[] nums);
}