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

namespace LeetCode.Algorithms.MinCostClimbingStairs;

/// <summary>
///     https://leetcode.com/problems/min-cost-climbing-stairs/
/// </summary>
public interface IMinCostClimbingStairs
{
    /// <summary>
    ///     Finds the minimum total cost to reach the top of a staircase where <paramref name="cost" /> gives the
    ///     cost of stepping on each stair, starting from either step 0 or step 1 and moving one or two steps at a
    ///     time.
    /// </summary>
    /// <param name="cost">The cost of stepping on each stair.</param>
    /// <returns>The minimum total cost to reach the top of the staircase.</returns>
    int MinCostClimbingStairs(int[] cost);
}