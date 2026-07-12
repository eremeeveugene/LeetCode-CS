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

namespace LeetCode.Algorithms.MaximumProductOfTwoDigits;

/// <summary>
///     https://leetcode.com/problems/maximum-product-of-two-digits/description/
/// </summary>
public interface IMaximumProductOfTwoDigits
{
    /// <summary>
    ///     Computes the maximum product obtainable by multiplying two digits of <paramref name="n" />.
    /// </summary>
    /// <param name="n">The non-negative integer whose digits are used to form the product.</param>
    /// <returns>The maximum product of any two digits of <paramref name="n" />.</returns>
    int MaxProduct(int n);
}