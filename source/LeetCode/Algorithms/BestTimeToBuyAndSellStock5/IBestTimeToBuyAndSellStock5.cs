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

namespace LeetCode.Algorithms.BestTimeToBuyAndSellStock5;

/// <summary>
///     https://leetcode.com/problems/best-time-to-buy-and-sell-stock-v/description/
/// </summary>
public interface IBestTimeToBuyAndSellStock5
{
    /// <summary>
    ///     Computes the maximum profit achievable with at most <paramref name="maxTransactions" /> transactions, where each
    ///     transaction may be a normal one (buy then sell) or a short one (sell then buy back).
    /// </summary>
    /// <param name="prices">The stock prices, where prices[i] is the price on the i-th day.</param>
    /// <param name="maxTransactions">The maximum number of transactions allowed.</param>
    /// <returns>The maximum achievable profit.</returns>
    long MaximumProfit(int[] prices, int maxTransactions);
}