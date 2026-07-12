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

namespace LeetCode.Algorithms.LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

/// <summary>
///     https://leetcode.com/problems/longest-strictly-increasing-or-strictly-decreasing-subarray/description/
/// </summary>
public interface ILongestStrictlyIncreasingOrStrictlyDecreasingSubarray
{
    /// <summary>
    ///     Finds the length of the longest subarray of <paramref name="nums" /> that is either strictly increasing or
    ///     strictly decreasing.
    /// </summary>
    /// <param name="nums">The array of integers to search for a monotonic subarray.</param>
    /// <returns>The length of the longest strictly increasing or strictly decreasing subarray.</returns>
    int LongestMonotonicSubarray(int[] nums);
}