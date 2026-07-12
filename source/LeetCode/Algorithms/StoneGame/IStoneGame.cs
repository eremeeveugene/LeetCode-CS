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

namespace LeetCode.Algorithms.StoneGame;

/// <summary>
///     https://leetcode.com/problems/stone-game/description/
/// </summary>
public interface IStoneGame
{
    /// <summary>
    ///     Determines whether Alice, who moves first and alternates turns with Bob taking stones from either
    ///     end of <paramref name="piles" /> with both playing optimally, wins the game.
    /// </summary>
    /// <param name="piles">The array of stone piles, with an even total number of piles.</param>
    /// <returns><see langword="true" /> if Alice wins; otherwise, <see langword="false" />.</returns>
    bool StoneGame(int[] piles);
}