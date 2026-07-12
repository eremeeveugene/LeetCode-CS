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

namespace LeetCode.Algorithms.NthTribonacciNumber;

/// <summary>
///     https://leetcode.com/problems/n-th-tribonacci-number/description/
/// </summary>
public interface INthTribonacciNumber
{
    /// <summary>
    ///     Computes the <paramref name="n" />th value of the Tribonacci sequence, where each term is the sum of the
    ///     three preceding terms, starting from T(0) = 0, T(1) = 1, T(2) = 1.
    /// </summary>
    /// <param name="n">The zero-based index of the Tribonacci term to compute.</param>
    /// <returns>The <paramref name="n" />th Tribonacci number.</returns>
    int Tribonacci(int n);
}