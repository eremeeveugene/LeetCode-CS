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

/// <inheritdoc />
public sealed class FinalPricesWithSpecialDiscountInShopStack : IFinalPricesWithSpecialDiscountInShop
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();

        for (var i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
            {
                prices[stack.Pop()] -= prices[i];
            }

            stack.Push(i);
        }

        return prices;
    }
}