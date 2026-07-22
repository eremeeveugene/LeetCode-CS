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

namespace LeetCode.Algorithms.FindXSumOfAllKLongSubarrays1;

/// <summary>
///     https://leetcode.com/problems/find-x-sum-of-all-k-long-subarrays-i/description/
/// </summary>
public interface IFindXSumOfAllKLongSubarrays1
{
    /// <summary>
    ///     Computes the x-sum of every contiguous subarray of length <paramref name="k" /> in <paramref name="nums" />. The
    ///     x-sum keeps only the top <paramref name="x" /> most frequent elements of the subarray, ties broken by the larger
    ///     value, and sums the kept elements with their original multiplicity; if the subarray has <c>x</c> or fewer
    ///     distinct elements, the x-sum is the sum of the whole subarray.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="k">The length of each contiguous subarray to evaluate.</param>
    /// <param name="x">The number of most frequent distinct elements to keep in each subarray.</param>
    /// <returns>An array containing the x-sum of each subarray of length <paramref name="k" />.</returns>
    int[] FindXSum(int[] nums, int k, int x);
}