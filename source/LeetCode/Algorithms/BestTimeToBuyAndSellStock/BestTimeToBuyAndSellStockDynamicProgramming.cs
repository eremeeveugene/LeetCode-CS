// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.BestTimeToBuyAndSellStock;

/// <inheritdoc />
public class BestTimeToBuyAndSellStockDynamicProgramming : IBestTimeToBuyAndSellStock
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;

        var min = prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            if (min > prices[i])
            {
                min = prices[i];
            }
            else
            {
                var profit = prices[i] - min;

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}