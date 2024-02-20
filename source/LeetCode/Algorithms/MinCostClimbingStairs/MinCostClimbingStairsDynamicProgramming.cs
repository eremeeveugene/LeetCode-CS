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

namespace LeetCode.Algorithms.MinCostClimbingStairs;

/// <inheritdoc />
public class MinCostClimbingStairsDynamicProgramming : IMinCostClimbingStairs
{
    public int MinCostClimbingStairs(int[] cost)
    {
        if (cost.Length == 0)
        {
            return 0;
        }

        var costs = new int[cost.Length + 1];

        costs[0] = 0;
        costs[1] = 0;

        for (var i = 2; i <= cost.Length; i++)
        {
            costs[i] = Math.Min(costs[i - 2] + cost[i - 2], costs[i - 1] + cost[i - 1]);
        }

        return costs[cost.Length];
    }
}