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

namespace LeetCode.Algorithms.FruitsIntoBaskets2;

/// <summary>
///     https://leetcode.com/problems/fruits-into-baskets-ii/description/
/// </summary>
public interface IFruitsIntoBaskets2
{
    /// <summary>
    ///     Counts the fruits from <paramref name="fruits" /> that remain unplaced after placing each fruit, from left to
    ///     right, into the leftmost available basket in <paramref name="baskets" /> with a capacity of at least the fruit
    ///     quantity.
    /// </summary>
    /// <param name="fruits">The quantities of the fruit types.</param>
    /// <param name="baskets">The capacities of the baskets.</param>
    /// <returns>The number of fruit types that remain unplaced.</returns>
    int NumOfUnplacedFruits(int[] fruits, int[] baskets);
}