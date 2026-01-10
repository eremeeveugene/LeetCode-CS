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

namespace LeetCode.Algorithms.MinimumCostToReachEveryPosition;

/// <inheritdoc />
public sealed class MinimumCostToReachEveryPositionGreedy : IMinimumCostToReachEveryPosition
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="cost"></param>
    /// <returns></returns>
    public int[] MinCosts(int[] cost)
    {
        var minCost = int.MaxValue;

        for (var i = 0; i < cost.Length; i++)
        {
            minCost = Math.Min(minCost, cost[i]);

            cost[i] = minCost;
        }

        return cost;
    }
}