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

namespace LeetCode.Algorithms.NextGreaterNumericallyBalancedNumber;

/// <summary>
///     https://leetcode.com/problems/next-greater-numerically-balanced-number/description/
/// </summary>
public interface INextGreaterNumericallyBalancedNumber
{
    /// <summary>
    ///     Finds the smallest numerically balanced number strictly greater than <paramref name="n" />. An integer is
    ///     numerically balanced when, for every digit <c>d</c> it contains, the digit <c>d</c> occurs exactly <c>d</c> times.
    /// </summary>
    /// <param name="n">The exclusive lower bound to search above.</param>
    /// <returns>The smallest numerically balanced number greater than <paramref name="n" />.</returns>
    int NextBeautifulNumber(int n);
}