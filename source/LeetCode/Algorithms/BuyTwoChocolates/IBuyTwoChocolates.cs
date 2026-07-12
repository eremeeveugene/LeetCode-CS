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

/// <summary>
///     https://leetcode.com/problems/buy-two-chocolates/
/// </summary>
public interface IBuyTwoChocolates
{
    /// <summary>
    ///     Computes the money left after buying the two cheapest chocolates from <paramref name="prices" /> without going
    ///     into debt.
    /// </summary>
    /// <param name="prices">The prices of the chocolates.</param>
    /// <param name="money">The initial amount of money.</param>
    /// <returns>The leftover money after buying two chocolates, or <paramref name="money" /> if no such purchase is possible.</returns>
    int BuyChoco(int[] prices, int money);
}