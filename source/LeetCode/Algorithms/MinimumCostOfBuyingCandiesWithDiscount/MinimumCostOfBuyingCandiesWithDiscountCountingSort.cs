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

namespace LeetCode.Algorithms.MinimumCostOfBuyingCandiesWithDiscount;

/// <inheritdoc />
public sealed class MinimumCostOfBuyingCandiesWithDiscountCountingSort : IMinimumCostOfBuyingCandiesWithDiscount
{
    private const int MaxCost = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumCost(int[] cost)
    {
        Span<byte> costFrequencies = stackalloc byte[MaxCost + 1];

        for (var i = 0; i < cost.Length; i++)
        {
            var candyCost = cost[i];

            costFrequencies[candyCost]++;
        }

        var minimumCost = 0;

        var j = 0;

        for (var candyCost = MaxCost; candyCost >= 1; candyCost--)
        {
            var frequency = costFrequencies[candyCost];

            for (var k = 0; k < frequency; k++)
            {
                if (j > 1)
                {
                    j = 0;
                }
                else
                {
                    minimumCost += candyCost;

                    j++;
                }
            }
        }

        return minimumCost;
    }
}