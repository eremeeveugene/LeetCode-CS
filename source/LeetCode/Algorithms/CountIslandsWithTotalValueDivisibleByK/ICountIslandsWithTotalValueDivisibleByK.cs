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

namespace LeetCode.Algorithms.CountIslandsWithTotalValueDivisibleByK;

/// <summary>
///     https://leetcode.com/problems/count-islands-with-total-value-divisible-by-k/description/
/// </summary>
public interface ICountIslandsWithTotalValueDivisibleByK
{
    /// <summary>
    ///     Counts the islands of 4-directionally connected positive cells whose total value is divisible by
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="grid">The matrix where positive values are land and 0 is water.</param>
    /// <param name="k">The positive divisor.</param>
    /// <returns>The number of islands in <paramref name="grid" /> whose total value is divisible by <paramref name="k" />.</returns>
    int CountIslands(int[][] grid, int k);
}