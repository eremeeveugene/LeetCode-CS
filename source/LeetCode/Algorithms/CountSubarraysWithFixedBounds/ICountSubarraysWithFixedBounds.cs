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

namespace LeetCode.Algorithms.CountSubarraysWithFixedBounds;

/// <summary>
///     https://leetcode.com/problems/count-subarrays-with-fixed-bounds
/// </summary>
public interface ICountSubarraysWithFixedBounds
{
    /// <summary>
    ///     Counts the fixed-bound subarrays of <paramref name="nums" /> whose minimum value equals
    ///     <paramref name="minK" /> and whose maximum value equals <paramref name="maxK" />.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="minK">The required minimum value of a subarray.</param>
    /// <param name="maxK">The required maximum value of a subarray.</param>
    /// <returns>The number of fixed-bound subarrays.</returns>
    long CountSubarrays(int[] nums, int minK, int maxK);
}