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

namespace LeetCode.Algorithms.SubarraysWithKDifferentIntegers;

/// <summary>
///     https://leetcode.com/problems/subarrays-with-k-different-integers/
/// </summary>
public interface ISubarraysWithKDifferentIntegers
{
    /// <summary>
    ///     Counts the contiguous subarrays of <paramref name="nums" /> that contain exactly
    ///     <paramref name="k" /> different integers.
    /// </summary>
    /// <param name="nums">The array of positive integers to search.</param>
    /// <param name="k">The exact number of distinct integers a qualifying subarray must contain.</param>
    /// <returns>The number of contiguous subarrays of <paramref name="nums" /> with exactly <paramref name="k" /> distinct integers.</returns>
    int SubarraysWithKDistinct(int[] nums, int k);
}