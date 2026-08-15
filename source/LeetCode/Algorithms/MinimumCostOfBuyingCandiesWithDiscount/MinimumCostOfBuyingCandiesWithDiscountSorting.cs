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
public sealed class MinimumCostOfBuyingCandiesWithDiscountSorting : IMinimumCostOfBuyingCandiesWithDiscount
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);

        var n = cost.Length;

        var minimumCost = 0;

        var j = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            var candyCost = cost[i];

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

        return minimumCost;
    }
}