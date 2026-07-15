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

namespace LeetCode.Algorithms.GcdOfOddAndEvenSums;

/// <summary>
///     https://leetcode.com/problems/gcd-of-odd-and-even-sums/description/
/// </summary>
public interface IGcdOfOddAndEvenSums
{
    /// <summary>
    ///     Computes the greatest common divisor of the sum of the smallest <paramref name="n" /> positive odd numbers and
    ///     the sum of the smallest <paramref name="n" /> positive even numbers.
    /// </summary>
    /// <param name="n">The count of smallest positive odd and even numbers to sum.</param>
    /// <returns>The greatest common divisor of the odd and even sums.</returns>
    int GcdOfOddEvenSums(int n);
}