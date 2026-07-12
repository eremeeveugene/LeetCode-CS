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

namespace LeetCode.Algorithms.BestTimeToBuyAndSellStock;

/// <summary>
///     https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
/// </summary>
public interface IBestTimeToBuyAndSellStock
{
    /// <summary>
    ///     Computes the maximum profit achievable by buying the stock on one day and selling it on a later day.
    /// </summary>
    /// <param name="prices">The stock prices, where prices[i] is the price on the i-th day.</param>
    /// <returns>The maximum achievable profit, or 0 if no profit is possible.</returns>
    int MaxProfit(int[] prices);
}