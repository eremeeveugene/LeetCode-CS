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

namespace LeetCode.Algorithms.FinalPricesWithSpecialDiscountInShop;

/// <inheritdoc />
public class FinalPricesWithSpecialDiscountInShopBruteForce : IFinalPricesWithSpecialDiscountInShop
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public int[] FinalPrices(int[] prices)
    {
        for (var i = 0; i < prices.Length - 1; i++)
        {
            for (var j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] > prices[i])
                {
                    continue;
                }

                prices[i] -= prices[j];

                break;
            }
        }

        return prices;
    }
}