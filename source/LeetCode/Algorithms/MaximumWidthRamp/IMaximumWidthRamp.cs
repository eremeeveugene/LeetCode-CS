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

namespace LeetCode.Algorithms.MaximumWidthRamp;

/// <summary>
///     https://leetcode.com/problems/maximum-width-ramp/
/// </summary>
public interface IMaximumWidthRamp
{
    /// <summary>
    ///     Finds the maximum width of a ramp in <paramref name="nums" />, defined as a pair of indices
    ///     <c>i &lt; j</c> such that <c>nums[i] &lt;= nums[j]</c>.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The maximum width of a ramp, or 0 if no ramp exists.</returns>
    int MaxWidthRamp(int[] nums);
}