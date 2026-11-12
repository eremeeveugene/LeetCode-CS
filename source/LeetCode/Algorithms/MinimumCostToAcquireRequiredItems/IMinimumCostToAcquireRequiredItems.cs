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

/// <summary>
///     https://leetcode.com/problems/minimum-cost-to-acquire-required-items/description/
/// </summary>
public interface IMinimumCostToAcquireRequiredItems
{
    /// <summary>
    ///     Computes the minimum total cost of buying items so that the contribution toward type 1 is at least
    ///     <paramref name="need1" /> and the contribution toward type 2 is at least <paramref name="need2" />.
    /// </summary>
    /// <param name="cost1">The cost of an item that contributes 1 unit to the type 1 requirement only.</param>
    /// <param name="cost2">The cost of an item that contributes 1 unit to the type 2 requirement only.</param>
    /// <param name="costBoth">The cost of an item that contributes 1 unit to both requirements.</param>
    /// <param name="need1">The required total contribution toward type 1.</param>
    /// <param name="need2">The required total contribution toward type 2.</param>
    /// <returns>The minimum possible total cost to satisfy both requirements.</returns>
    long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2);
}