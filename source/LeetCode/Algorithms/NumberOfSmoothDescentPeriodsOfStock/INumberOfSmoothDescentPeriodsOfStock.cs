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

namespace LeetCode.Algorithms.NumberOfSmoothDescentPeriodsOfStock;

/// <summary>
///     https://leetcode.com/problems/number-of-smooth-descent-periods-of-a-stock/description/
/// </summary>
public interface INumberOfSmoothDescentPeriodsOfStock
{
    /// <summary>
    ///     Counts the number of smooth descent periods in <paramref name="prices" />, where each period is a
    ///     contiguous subarray in which each price is exactly one less than the price before it.
    /// </summary>
    /// <param name="prices">The array of daily stock prices.</param>
    /// <returns>The total number of smooth descent periods in <paramref name="prices" />.</returns>
    long GetDescentPeriods(int[] prices);
}