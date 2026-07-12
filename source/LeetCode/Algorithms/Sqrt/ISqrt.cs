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

namespace LeetCode.Algorithms.Sqrt;

/// <summary>
///     https://leetcode.com/problems/sqrtx/description/
/// </summary>
public interface ISqrt
{
    /// <summary>
    ///     Computes the integer square root of <paramref name="x" />, truncating any fractional part.
    /// </summary>
    /// <param name="x">The non-negative integer to compute the square root of.</param>
    /// <returns>The largest integer whose square is less than or equal to <paramref name="x" />.</returns>
    int MySqrt(int x);
}