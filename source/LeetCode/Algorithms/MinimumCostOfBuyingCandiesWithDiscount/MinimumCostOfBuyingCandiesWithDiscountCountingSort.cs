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
    public int MinimumCost(int[] costs)
    {
        Span<byte> costFrequencies = stackalloc byte[MaxCost + 1];

        for (var i = 0; i < costs.Length; i++)
        {
            var cost = costs[i];

            costFrequencies[cost]++;
        }

        var minimumCost = 0;

        var j = 0;

        for (var cost = MaxCost; cost >= 1; cost--)
        {
            var frequency = costFrequencies[cost];

            for (var k = 0; k < frequency; k++)
            {
                if (j > 1)
                {
                    j = 0;
                }
                else
                {
                    minimumCost += cost;

                    j++;
                }
            }
        }

        return minimumCost;
    }
}