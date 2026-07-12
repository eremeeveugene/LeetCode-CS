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

namespace LeetCode.Algorithms.CountOfInterestingSubarrays;

/// <summary>
///     https://leetcode.com/problems/count-of-interesting-subarrays/description/
/// </summary>
public interface ICountOfInterestingSubarrays
{
    /// <summary>
    ///     Counts the subarrays of <paramref name="nums" /> that are "interesting", meaning the count of elements
    ///     satisfying <c>nums[i] % modulo == k</c> within the subarray is itself congruent to <paramref name="k" />
    ///     modulo <paramref name="modulo" />.
    /// </summary>
    /// <param name="nums">The list of integers to examine.</param>
    /// <param name="modulo">The modulus used to evaluate elements and subarray counts.</param>
    /// <param name="k">The target remainder used to evaluate elements and subarray counts.</param>
    /// <returns>The total number of interesting subarrays.</returns>
    long CountInterestingSubarrays(IList<int> nums, int modulo, int k);
}