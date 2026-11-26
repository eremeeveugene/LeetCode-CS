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

namespace LeetCode.Algorithms.StoneRemovalGame;

/// <summary>
///     https://leetcode.com/problems/stone-removal-game/description/
/// </summary>
public interface IStoneRemovalGame
{
    /// <summary>
    ///     Determines whether Alice wins the game in which she first removes exactly 10 stones and each following turn
    ///     removes exactly one stone fewer than the opponent's previous turn, the player unable to move losing.
    /// </summary>
    /// <param name="n">The number of stones in the pile.</param>
    /// <returns><see langword="true" /> if Alice wins the game; otherwise, <see langword="false" />.</returns>
    bool CanAliceWin(int n);
}