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

namespace LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

/// <summary>
///     https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/description/
/// </summary>
public interface IMaximumProductOfTwoElementsInAnArray
{
    /// <summary>
    ///     Computes the maximum value of (nums[i] - 1) * (nums[j] - 1) for two distinct indices i and j in
    ///     <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers to choose two distinct elements from.</param>
    /// <returns>The maximum product of (nums[i] - 1) * (nums[j] - 1) over all pairs of distinct indices.</returns>
    int MaxProduct(int[] nums);
}