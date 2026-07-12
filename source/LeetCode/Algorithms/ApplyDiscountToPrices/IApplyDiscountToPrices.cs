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

namespace LeetCode.Algorithms.ApplyDiscountToPrices;

/// <summary>
///     https://leetcode.com/problems/apply-discount-to-prices/description/
/// </summary>
public interface IApplyDiscountToPrices
{
    /// <summary>
    ///     Applies a <paramref name="discount" /> percentage to every price in <paramref name="sentence" /> and formats the
    ///     updated prices with exactly two decimal places.
    /// </summary>
    /// <param name="sentence">The sentence containing words and prices, where a price is a dollar sign followed by digits.</param>
    /// <param name="discount">The discount percentage to apply to each price.</param>
    /// <returns>The modified sentence with all prices updated to reflect the discount.</returns>
    string DiscountPrices(string sentence, int discount);
}