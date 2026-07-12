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

namespace LeetCode.Algorithms.UglyNumber;

/// <summary>
///     https://leetcode.com/problems/ugly-number/
/// </summary>
public interface IUglyNumber
{
    /// <summary>
    ///     Determines whether <paramref name="n" /> is an ugly number — a positive integer whose only prime
    ///     factors are 2, 3, and 5.
    /// </summary>
    /// <param name="n">The integer to check.</param>
    /// <returns><see langword="true" /> if <paramref name="n" /> is an ugly number; otherwise, <see langword="false" />.</returns>
    bool IsUgly(int n);
}