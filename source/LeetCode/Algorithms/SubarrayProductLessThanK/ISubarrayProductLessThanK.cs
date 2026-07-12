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

namespace LeetCode.Algorithms.SubarrayProductLessThanK;

/// <summary>
///     https://leetcode.com/problems/subarray-product-less-than-k/description/
/// </summary>
public interface ISubarrayProductLessThanK
{
    /// <summary>
    ///     Counts the contiguous subarrays of <paramref name="nums" /> whose product of all elements is
    ///     strictly less than <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of positive integers to search.</param>
    /// <param name="k">The exclusive upper bound on the subarray product.</param>
    /// <returns>The number of contiguous subarrays whose product is less than <paramref name="k" />.</returns>
    int NumSubarrayProductLessThanK(int[] nums, int k);
}