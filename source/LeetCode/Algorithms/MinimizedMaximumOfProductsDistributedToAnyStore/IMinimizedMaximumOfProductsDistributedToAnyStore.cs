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

namespace LeetCode.Algorithms.MinimizedMaximumOfProductsDistributedToAnyStore;

/// <summary>
///     https://leetcode.com/problems/minimized-maximum-of-products-distributed-to-any-store/description/
/// </summary>
public interface IMinimizedMaximumOfProductsDistributedToAnyStore
{
    /// <summary>
    ///     Distributes the product quantities in <paramref name="quantities" /> across <paramref name="n" /> stores,
    ///     where each store sells only one product, to minimize the maximum number of products given to any store.
    /// </summary>
    /// <param name="n">The number of stores available.</param>
    /// <param name="quantities">The quantity of each product that must be distributed.</param>
    /// <returns>The minimum possible value of the maximum number of products assigned to any store.</returns>
    int MinimizedMaximum(int n, int[] quantities);
}