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

namespace LeetCode.Algorithms.SumMultiples;

/// <summary>
///     https://leetcode.com/problems/sum-multiples/description/
/// </summary>
public interface ISumMultiples
{
    /// <summary>
    ///     Computes the sum of all integers from 1 to <paramref name="n" />, inclusive, that are divisible by
    ///     3, 5, or 7.
    /// </summary>
    /// <param name="n">The inclusive upper bound of the range to sum.</param>
    /// <returns>The sum of all qualifying multiples from 1 to <paramref name="n" />.</returns>
    int SumOfMultiples(int n);
}