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

namespace LeetCode.Algorithms.FindThePowerOfKSizeSubarrays1;

/// <summary>
///     https://leetcode.com/problems/find-the-power-of-k-size-subarrays-i/description/
/// </summary>
public interface IFindThePowerOfKSizeSubarrays1
{
    /// <summary>
    ///     Computes the "power" of every contiguous subarray of length <paramref name="k" /> in <paramref name="nums" />, where the power is the maximum
    ///     element if the subarray forms a sequence of consecutive integers, or <c>-1</c> otherwise.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="k">The length of each subarray to evaluate.</param>
    /// <returns>An array containing the power of each subarray of length <paramref name="k" />.</returns>
    int[] ResultsArray(int[] nums, int k);
}