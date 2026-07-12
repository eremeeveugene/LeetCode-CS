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

namespace LeetCode.Algorithms.FinalPricesWithSpecialDiscountInShop;

/// <summary>
///     https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/description/
/// </summary>
public interface IFinalPricesWithSpecialDiscountInShop
{
    /// <summary>
    ///     Computes the final price of each item in <paramref name="prices" /> after applying a special discount equal to
    ///     the first subsequent price that is less than or equal to the item's price.
    /// </summary>
    /// <param name="prices">The array of item prices.</param>
    /// <returns>An array containing the final price of each item after the discount.</returns>
    int[] FinalPrices(int[] prices);
}