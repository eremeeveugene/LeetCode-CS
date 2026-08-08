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

namespace LeetCode.Algorithms.SmallestDivisibleDigitProduct1;

/// <summary>
///     https://leetcode.com/problems/smallest-divisible-digit-product-i/description/
/// </summary>
public interface ISmallestDivisibleDigitProduct1
{
    /// <summary>
    ///     Determines the smallest integer greater than or equal to <paramref name="n" /> whose digit product is
    ///     divisible by <paramref name="t" />.
    /// </summary>
    /// <param name="n">The lower bound, inclusive, to start searching from.</param>
    /// <param name="t">The divisor the digit product must be divisible by.</param>
    /// <returns>The smallest qualifying integer.</returns>
    int SmallestNumber(int n, int t);
}