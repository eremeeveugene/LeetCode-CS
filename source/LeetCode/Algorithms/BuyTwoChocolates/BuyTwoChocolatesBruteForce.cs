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
public sealed class BuyTwoChocolatesBruteForce : IBuyTwoChocolates
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int BuyChoco(int[] prices, int money)
    {
        int? result = null;

        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = i + 1; j < prices.Length; j++)
            {
                var leftover = money - prices[i] - prices[j];

                if (leftover < 0)
                {
                    continue;
                }

                if (result.HasValue)
                {
                    if (leftover > result)
                    {
                        result = leftover;
                    }
                }
                else
                {
                    result = leftover;
                }
            }
        }

        return result ?? money;
    }
}