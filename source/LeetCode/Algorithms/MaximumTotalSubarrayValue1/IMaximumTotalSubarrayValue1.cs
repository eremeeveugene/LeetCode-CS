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

namespace LeetCode.Algorithms.MaximumTotalSubarrayValue1;

/// <summary>
///     https://leetcode.com/problems/maximum-total-subarray-value-i/description/
/// </summary>
public interface IMaximumTotalSubarrayValue1
{
    /// <summary>
    ///     Calculates the maximum possible total value achievable by choosing exactly
    ///     <paramref name="k" /> non-empty subarrays of <paramref name="nums" />, where the value of a
    ///     subarray is defined as the difference between its maximum and minimum elements.
    /// </summary>
    /// <param name="nums">An integer array of length n.</param>
    /// <param name="k">The exact number of (possibly overlapping or repeated) subarrays to choose.</param>
    /// <returns>The maximum possible total value.</returns>
    long MaxTotalValue(int[] nums, int k);
}