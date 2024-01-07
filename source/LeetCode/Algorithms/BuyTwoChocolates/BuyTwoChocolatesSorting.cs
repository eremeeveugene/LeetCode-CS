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

public static class BuyTwoChocolatesSorting
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="prices"></param>
    /// <param name="money"></param>
    /// <returns></returns>
    public static int GetResult(int[] prices, int money)
    {
        Array.Sort(prices);

        var leftover = money - prices[0] - prices[1];

        return leftover < 0 ? money : leftover;
    }
}