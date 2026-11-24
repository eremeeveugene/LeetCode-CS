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

namespace LeetCode.Algorithms.MaximumSubarrayWithEqualProducts;

/// <summary>
///     https://leetcode.com/problems/maximum-subarray-with-equal-products/description/
/// </summary>
public interface IMaximumSubarrayWithEqualProducts
{
    /// <summary>
    ///     Finds the length of the longest subarray of <paramref name="nums" /> whose product of all elements is equal to
    ///     the product of its least common multiple and its greatest common divisor.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <returns>The length of the longest product equivalent subarray.</returns>
    int MaxLength(int[] nums);
}