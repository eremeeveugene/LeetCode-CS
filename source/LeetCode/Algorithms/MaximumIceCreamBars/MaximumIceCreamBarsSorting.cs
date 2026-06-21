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
public sealed class MaximumIceCreamBarsSorting : IMaximumIceCreamBars
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="costs"></param>
    /// <param name="coins"></param>
    /// <returns></returns>
    public int MaxIceCream(int[] costs, int coins)
    {
        var n = costs.Length;

        Array.Sort(costs);

        var count = 0;

        for (var i = 0; i < n; i++)
        {
            var cost = costs[i];

            if (coins < cost)
            {
                break;
            }

            coins -= cost;

            count++;
        }

        return count;
    }
}