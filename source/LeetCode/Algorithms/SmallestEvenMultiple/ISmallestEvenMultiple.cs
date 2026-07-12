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

namespace LeetCode.Algorithms.SmallestEvenMultiple;

/// <summary>
///     https://leetcode.com/problems/smallest-even-multiple/
/// </summary>
public interface ISmallestEvenMultiple
{
    /// <summary>
    ///     Computes the smallest positive integer that is a multiple of both 2 and <paramref name="n" />.
    /// </summary>
    /// <param name="n">The positive integer to find the smallest even multiple of.</param>
    /// <returns>The smallest positive integer divisible by both 2 and <paramref name="n" />.</returns>
    int SmallestEvenMultiple(int n);
}