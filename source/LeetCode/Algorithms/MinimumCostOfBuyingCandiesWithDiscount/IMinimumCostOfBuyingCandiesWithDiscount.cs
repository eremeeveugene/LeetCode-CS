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

/// <summary>
///     https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/description/
/// </summary>
public interface IMinimumCostOfBuyingCandiesWithDiscount
{
    /// <summary>
    ///     Computes the minimum cost of buying all candies given that, for every two candies bought, a third candy with cost less than or equal to the minimum of the two is free.
    /// </summary>
    /// <param name="cost">The array of candy costs.</param>
    /// <returns>The minimum total cost to buy all candies in <paramref name="cost" />.</returns>
    int MinimumCost(int[] cost);
}