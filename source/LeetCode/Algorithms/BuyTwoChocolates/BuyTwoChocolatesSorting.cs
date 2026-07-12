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

namespace LeetCode.Algorithms.BuyTwoChocolates;

/// <inheritdoc />
public sealed class BuyTwoChocolatesSorting : IBuyTwoChocolates
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int BuyChoco(int[] prices, int money)
    {
        Array.Sort(prices);

        var leftover = money - prices[0] - prices[1];

        return leftover < 0 ? money : leftover;
    }
}