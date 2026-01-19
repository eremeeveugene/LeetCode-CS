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

/// <inheritdoc />
public sealed class BestTimeToBuyAndSellStock5DynamicProgramming : IBestTimeToBuyAndSellStock5
{
    /// <summary>
    ///     Time complexity - O(n * k)
    ///     Space complexity - O(k)
    /// </summary>
    /// <param name="prices"></param>
    /// <param name="maxTransactions"></param>
    /// <returns></returns>
    public long MaximumProfit(int[] prices, int maxTransactions)
    {
        var days = prices.Length;

        var transactionStatesCount = maxTransactions + 1;

        Span<long> profits = stackalloc long[transactionStatesCount];
        Span<long> longHoldProfits = stackalloc long[transactionStatesCount];
        Span<long> shortHoldProfits = stackalloc long[transactionStatesCount];

        var initialLongProfit = -prices[0];
        var initialShortProfit = prices[0];

        for (var completedTransactions = 1; completedTransactions < transactionStatesCount; completedTransactions++)
        {
            longHoldProfits[completedTransactions] = initialLongProfit;
            shortHoldProfits[completedTransactions] = initialShortProfit;
        }

        for (var day = 1; day < days; day++)
        {
            long currentPrice = prices[day];

            for (var completedTransactions = maxTransactions; completedTransactions > 0; completedTransactions--)
            {
                var longHoldProfit = longHoldProfits[completedTransactions];
                var shortHoldProfit = shortHoldProfits[completedTransactions];

                var profitAfterClosingLong = longHoldProfit + currentPrice;
                var profitAfterClosingShort = shortHoldProfit - currentPrice;

                var profitAfterClosing = Math.Max(profitAfterClosingLong, profitAfterClosingShort);

                profits[completedTransactions] = Math.Max(profits[completedTransactions], profitAfterClosing);

                var previousTransaction = completedTransactions - 1;

                var openLongFromCash = profits[previousTransaction] - currentPrice;
                var openShortFromCash = profits[previousTransaction] + currentPrice;

                longHoldProfits[completedTransactions] = Math.Max(longHoldProfit, openLongFromCash);
                shortHoldProfits[completedTransactions] = Math.Max(shortHoldProfit, openShortFromCash);
            }
        }

        return profits[^1];
    }
}