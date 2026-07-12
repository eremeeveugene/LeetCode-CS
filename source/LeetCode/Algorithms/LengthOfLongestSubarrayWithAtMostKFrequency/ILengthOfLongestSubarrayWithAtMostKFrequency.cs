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

namespace LeetCode.Algorithms.LengthOfLongestSubarrayWithAtMostKFrequency;

/// <summary>
///     https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency/description/
/// </summary>
public interface ILengthOfLongestSubarrayWithAtMostKFrequency
{
    /// <summary>
    ///     Finds the length of the longest contiguous subarray of <paramref name="nums" /> in which no element occurs more than <paramref name="k" /> times.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="k">The maximum allowed frequency of any element within the subarray.</param>
    /// <returns>The length of the longest valid subarray.</returns>
    int MaxSubarrayLength(int[] nums, int k);
}