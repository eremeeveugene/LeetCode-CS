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

namespace LeetCode.Algorithms.SmallestIntegerDivisibleByK;

/// <summary>
///     https://leetcode.com/problems/smallest-integer-divisible-by-k/description/
/// </summary>
public interface ISmallestIntegerDivisibleByK
{
    /// <summary>
    ///     Finds the length of the smallest positive integer that is divisible by <paramref name="k" /> and contains
    ///     only the digit 1.
    /// </summary>
    /// <param name="k">The positive integer divisor.</param>
    /// <returns>
    ///     The length of the smallest positive integer consisting only of the digit 1 that is divisible by
    ///     <paramref name="k" />, or -1 if no such integer exists.
    /// </returns>
    int SmallestRepunitDivByK(int k);
}