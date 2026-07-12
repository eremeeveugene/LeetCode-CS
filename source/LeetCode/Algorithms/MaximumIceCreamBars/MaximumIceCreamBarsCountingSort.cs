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

namespace LeetCode.Algorithms.MaximumIceCreamBars;

/// <inheritdoc />
public sealed class MaximumIceCreamBarsCountingSort : IMaximumIceCreamBars
{
    private const int MaxCost = 100_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxIceCream(int[] costs, int coins)
    {
        var n = costs.Length;

        Span<int> costsFrequencies = stackalloc int[MaxCost + 1];

        for (var i = 0; i < n; i++)
        {
            var cost = costs[i];

            costsFrequencies[cost]++;
        }

        var count = 0;

        for (var cost = 1; cost < costsFrequencies.Length; cost++)
        {
            if (coins < cost)
            {
                break;
            }

            var costFrequency = costsFrequencies[cost];

            var affordableCount = Math.Min(costFrequency, coins / cost);

            coins -= affordableCount * cost;
            count += affordableCount;
        }

        return count;
    }
}