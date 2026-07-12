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

namespace LeetCode.Algorithms.ProductOfArrayExceptSelf;

/// <summary>
///     https://leetcode.com/problems/product-of-array-except-self/description/
/// </summary>
public interface IProductOfArrayExceptSelf
{
    /// <summary>
    ///     Computes, for each index of <paramref name="nums" />, the product of all elements except the one at that
    ///     index.
    /// </summary>
    /// <param name="nums">The array of integers to process.</param>
    /// <returns>An array where each element is the product of all elements of <paramref name="nums" /> except itself.</returns>
    int[] ProductExceptSelf(int[] nums);
}