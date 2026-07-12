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

namespace LeetCode.Algorithms.DivisibleAndNonDivisibleSumsDifference;

/// <summary>
///     https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/
/// </summary>
public interface IDivisibleAndNonDivisibleSumsDifference
{
    /// <summary>
    ///     Computes the difference between the sum of integers from 1 to <paramref name="n" /> that are not divisible by
    ///     <paramref name="m" /> and the sum of those that are divisible by <paramref name="m" />.
    /// </summary>
    /// <param name="n">The inclusive upper bound of the integer range to sum, starting from 1.</param>
    /// <param name="m">The divisor used to classify integers as divisible or non-divisible.</param>
    /// <returns>The difference between the non-divisible sum and the divisible sum.</returns>
    int DifferenceOfSums(int n, int m);
}