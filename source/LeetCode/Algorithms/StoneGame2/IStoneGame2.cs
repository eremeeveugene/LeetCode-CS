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

namespace LeetCode.Algorithms.StoneGame2;

/// <summary>
///     https://leetcode.com/problems/stone-game-ii/
/// </summary>
public interface IStoneGame2
{
    /// <summary>
    ///     Computes the maximum number of stones Alice can collect from <paramref name="piles" /> when she and
    ///     Bob alternately take the first X (1 &lt;= X &lt;= 2M) piles from the front, both playing optimally
    ///     and M starting at 1 and updating after each turn.
    /// </summary>
    /// <param name="piles">The array of stone piles, taken in order from the front.</param>
    /// <returns>The maximum number of stones Alice can collect.</returns>
    int StoneGameII(int[] piles);
}