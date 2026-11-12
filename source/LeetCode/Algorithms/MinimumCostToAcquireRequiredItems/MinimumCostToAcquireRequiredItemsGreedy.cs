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

namespace LeetCode.Algorithms.MinimumCostToAcquireRequiredItems;

/// <inheritdoc />
public sealed class MinimumCostToAcquireRequiredItemsGreedy : IMinimumCostToAcquireRequiredItems
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2)
    {
        if (cost1 + cost2 <= costBoth)
        {
            return ((long)need1 * cost1) + ((long)need2 * cost2);
        }

        var commonNeed = Math.Min(need1, need2);
        var remainingNeed1 = need1 - commonNeed;
        var remainingNeed2 = need2 - commonNeed;

        var type1UnitCost = Math.Min(cost1, costBoth);
        var type2UnitCost = Math.Min(cost2, costBoth);

        return ((long)commonNeed * costBoth) + ((long)remainingNeed1 * type1UnitCost) + ((long)remainingNeed2 * type2UnitCost);
    }
}