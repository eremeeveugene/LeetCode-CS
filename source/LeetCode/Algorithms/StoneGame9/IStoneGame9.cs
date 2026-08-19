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

namespace LeetCode.Algorithms.StoneGame9;

/// <summary>
///     https://leetcode.com/problems/stone-game-ix/
/// </summary>
public interface IStoneGame9
{
    /// <summary>
    ///     Determines whether Alice wins when she and Bob optimally remove stones and a player loses after making
    ///     the sum of all removed stones divisible by three.
    /// </summary>
    /// <param name="stones">The values of the available stones.</param>
    /// <returns><see langword="true" /> if Alice wins; otherwise, <see langword="false" />.</returns>
    bool StoneGameIX(int[] stones);
}