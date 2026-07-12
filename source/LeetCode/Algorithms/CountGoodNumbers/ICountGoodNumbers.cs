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

namespace LeetCode.Algorithms.CountGoodNumbers;

/// <summary>
///     https://leetcode.com/problems/count-good-numbers/description/
/// </summary>
public interface ICountGoodNumbers
{
    /// <summary>
    ///     Counts the good digit strings of length <paramref name="n" />, where digits at even indices are even and digits
    ///     at odd indices are prime, returning the result modulo 10^9 + 7.
    /// </summary>
    /// <param name="n">The length of the digit strings.</param>
    /// <returns>The number of good digit strings of length <paramref name="n" /> modulo 10^9 + 7.</returns>
    int CountGoodNumbers(long n);
}