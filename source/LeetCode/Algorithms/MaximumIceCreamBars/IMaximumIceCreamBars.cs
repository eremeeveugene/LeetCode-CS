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

namespace LeetCode.Algorithms.MaximumIceCreamBars;

/// <summary>
///     https://leetcode.com/problems/maximum-ice-cream-bars/description
/// </summary>
public interface IMaximumIceCreamBars
{
    /// <summary>
    ///     Determines the maximum number of ice cream bars that can be bought with <paramref name="coins" /> coins, where
    ///     <paramref name="costs" />[i] is the price of the i-th ice cream bar. Each bar can be bought at most once and the
    ///     order of purchase does not matter.
    /// </summary>
    /// <param name="costs">The prices of the available ice cream bars.</param>
    /// <param name="coins">The total amount of coins available to spend.</param>
    /// <returns>The maximum number of ice cream bars that can be bought.</returns>
    int MaxIceCream(int[] costs, int coins);
}