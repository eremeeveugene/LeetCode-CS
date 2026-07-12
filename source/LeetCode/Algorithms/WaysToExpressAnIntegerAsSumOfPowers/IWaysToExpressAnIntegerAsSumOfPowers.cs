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

namespace LeetCode.Algorithms.WaysToExpressAnIntegerAsSumOfPowers;

/// <summary>
///     https://leetcode.com/problems/ways-to-express-an-integer-as-sum-of-powers/description/
/// </summary>
public interface IWaysToExpressAnIntegerAsSumOfPowers
{
    /// <summary>
    ///     Counts the number of ways to express <paramref name="n" /> as the sum of the <paramref name="x" />th
    ///     power of unique positive integers.
    /// </summary>
    /// <param name="n">The target integer to express as a sum of powers.</param>
    /// <param name="x">The exponent applied to each unique positive integer in the sum.</param>
    /// <returns>The number of ways to express <paramref name="n" /> as such a sum, modulo 10^9 + 7.</returns>
    int NumberOfWays(int n, int x);
}