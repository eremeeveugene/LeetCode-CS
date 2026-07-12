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

namespace LeetCode.Algorithms.MinimumPositiveSumSubarray;

/// <summary>
///     https://leetcode.com/problems/minimum-positive-sum-subarray/description/
/// </summary>
public interface IMinimumPositiveSumSubarray
{
    /// <summary>
    ///     Finds the minimum positive sum among all subarrays of <paramref name="nums" /> whose length is between
    ///     <paramref name="l" /> and <paramref name="r" />, inclusive.
    /// </summary>
    /// <param name="nums">The list of integers to search for subarrays.</param>
    /// <param name="l">The minimum allowed length of a subarray.</param>
    /// <param name="r">The maximum allowed length of a subarray.</param>
    /// <returns>The minimum positive subarray sum, or -1 if no subarray has a positive sum.</returns>
    int MinimumSumSubarray(IList<int> nums, int l, int r);
}