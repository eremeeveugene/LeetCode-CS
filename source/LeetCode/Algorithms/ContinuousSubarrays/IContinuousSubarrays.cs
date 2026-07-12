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

namespace LeetCode.Algorithms.ContinuousSubarrays;

/// <summary>
///     https://leetcode.com/problems/continuous-subarrays/description/
/// </summary>
public interface IContinuousSubarrays
{
    /// <summary>
    ///     Counts the total number of continuous subarrays of <paramref name="nums" /> in which the absolute difference
    ///     between any two elements is at most 2.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The total number of qualifying continuous subarrays.</returns>
    long ContinuousSubarrays(int[] nums);
}