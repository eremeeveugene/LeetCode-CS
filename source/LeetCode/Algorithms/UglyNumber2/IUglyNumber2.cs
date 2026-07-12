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

namespace LeetCode.Algorithms.UglyNumber2;

/// <summary>
///     https://leetcode.com/problems/ugly-number-ii/
/// </summary>
public interface IUglyNumber2
{
    /// <summary>
    ///     Finds the <paramref name="n" />th ugly number — a positive integer whose only prime factors are 2, 3,
    ///     and 5.
    /// </summary>
    /// <param name="n">The 1-based position of the ugly number to find.</param>
    /// <returns>The <paramref name="n" />th ugly number.</returns>
    int NthUglyNumber(int n);
}