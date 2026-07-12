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

namespace LeetCode.Algorithms.ArrangingCoins;

/// <summary>
///     https://leetcode.com/problems/arranging-coins/
/// </summary>
public interface IArrangingCoins
{
    /// <summary>
    ///     Computes the number of complete rows of a staircase that can be built with <paramref name="n" /> coins, where
    ///     the i-th row contains exactly i coins.
    /// </summary>
    /// <param name="n">The number of coins available.</param>
    /// <returns>The number of complete staircase rows that can be built.</returns>
    int ArrangeCoins(int n);
}