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

namespace LeetCode.Algorithms.SmallestRange1;

/// <summary>
///     https://leetcode.com/problems/smallest-range-i/description/
/// </summary>
public interface ISmallestRange1
{
    /// <summary>
    ///     Computes the smallest possible difference between the maximum and minimum values of
    ///     <paramref name="nums" /> after adding any integer in the range [-k, k] to each element.
    /// </summary>
    /// <param name="nums">The array of integers to adjust.</param>
    /// <param name="k">The maximum magnitude of the adjustment that can be applied to each element.</param>
    /// <returns>The minimum possible difference between the maximum and minimum values after adjustment.</returns>
    int SmallestRangeI(int[] nums, int k);
}