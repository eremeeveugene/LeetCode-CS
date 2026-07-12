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

/// <summary>
///     https://leetcode.com/problems/minimum-cost-to-reach-every-position/description/
/// </summary>
public interface IMinimumCostToReachEveryPosition
{
    /// <summary>
    ///     Computes, for each position, the minimum cost to reach it, given that moving from position <c>j</c> to
    ///     position <c>i</c> (where <c>j &lt;= i</c>) costs <c>cost[i]</c>.
    /// </summary>
    /// <param name="cost">The cost associated with moving to each position.</param>
    /// <returns>An array where each entry is the minimum cost to reach the corresponding position.</returns>
    int[] MinCosts(int[] cost);
}