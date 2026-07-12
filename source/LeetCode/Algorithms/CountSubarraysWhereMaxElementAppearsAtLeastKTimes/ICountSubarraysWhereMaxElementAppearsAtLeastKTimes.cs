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

namespace LeetCode.Algorithms.CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

/// <summary>
///     https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times/description/
/// </summary>
public interface ICountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    /// <summary>
    ///     Counts the subarrays of <paramref name="nums" /> in which the maximum element of the array appears at least
    ///     <paramref name="k" /> times.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="k">The minimum number of occurrences of the maximum element.</param>
    /// <returns>The number of subarrays where the maximum element appears at least <paramref name="k" /> times.</returns>
    long CountSubarrays(int[] nums, int k);
}