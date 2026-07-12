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

namespace LeetCode.Algorithms.MaximumAverageSubarray1;

/// <summary>
///     https://leetcode.com/problems/maximum-average-subarray-i/description/
/// </summary>
public interface IMaximumAverageSubarray1
{
    /// <summary>
    ///     Finds the maximum average value of any contiguous subarray of <paramref name="nums" /> with length
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <param name="k">The length of the subarray to average.</param>
    /// <returns>The maximum average value achievable by a contiguous subarray of length <paramref name="k" />.</returns>
    double FindMaxAverage(int[] nums, int k);
}