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

namespace LeetCode.Algorithms.Pow;

/// <summary>
///     https://leetcode.com/problems/powx-n/description/
/// </summary>
public interface IPow
{
    /// <summary>
    ///     Calculates <paramref name="x" /> raised to the power <paramref name="n" />.
    /// </summary>
    /// <param name="x">The base value.</param>
    /// <param name="n">The exponent, which may be negative.</param>
    /// <returns>The value of <paramref name="x" /> raised to the power <paramref name="n" />.</returns>
    double MyPow(double x, int n);
}