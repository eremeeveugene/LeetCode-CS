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

namespace LeetCode.Algorithms.BuyTwoChocolates;

/// <inheritdoc />
public class BuyTwoChocolatesMinimumTwoPrices : IBuyTwoChocolates
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="prices"></param>
    /// <param name="money"></param>
    /// <returns></returns>
    public int BuyChoco(int[] prices, int money)
    {
        var min1 = prices[0];
        var min2 = prices[1];

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min1)
            {
                min2 = min1;
                min1 = prices[i];
            }
            else if (prices[i] < min2)
            {
                min2 = prices[i];
            }
        }

        var leftover = money - min1 - min2;

        return leftover < 0 ? money : leftover;
    }
}