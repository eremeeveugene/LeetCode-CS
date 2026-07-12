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

namespace LeetCode.Algorithms.FruitIntoBaskets;

/// <summary>
///     https://leetcode.com/problems/fruit-into-baskets/description/
/// </summary>
public interface IFruitIntoBaskets
{
    /// <summary>
    ///     Finds the maximum number of fruits that can be picked from a contiguous group of trees in
    ///     <paramref name="fruits" /> using at most two baskets, each holding only a single fruit type.
    /// </summary>
    /// <param name="fruits">The types of fruit produced by each tree in the row.</param>
    /// <returns>The maximum number of fruits that can be picked.</returns>
    int TotalFruit(int[] fruits);
}