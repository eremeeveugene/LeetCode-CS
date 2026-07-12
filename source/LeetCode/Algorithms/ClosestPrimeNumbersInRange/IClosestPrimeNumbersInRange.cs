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

namespace LeetCode.Algorithms.ClosestPrimeNumbersInRange;

/// <summary>
///     https://leetcode.com/problems/closest-prime-numbers-in-range/description/
/// </summary>
public interface IClosestPrimeNumbersInRange
{
    /// <summary>
    ///     Finds the pair of prime numbers within the inclusive range [<paramref name="left" />, <paramref name="right" />]
    ///     that have the smallest absolute difference between them.
    /// </summary>
    /// <param name="left">The inclusive lower bound of the range.</param>
    /// <param name="right">The inclusive upper bound of the range.</param>
    /// <returns>
    ///     An array containing the two closest primes in ascending order, or [-1, -1] if fewer than two primes exist in
    ///     the range.
    /// </returns>
    int[] ClosestPrimes(int left, int right);
}