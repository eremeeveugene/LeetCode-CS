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

namespace LeetCode.Algorithms.NimGame;

/// <summary>
///     https://leetcode.com/problems/nim-game/description/
/// </summary>
public interface INimGame
{
    /// <summary>
    ///     Determines whether the first player can guarantee a win in the Nim game starting with
    ///     <paramref name="n" /> stones, where each turn removes 1, 2, or 3 stones and the player who removes the
    ///     last stone wins.
    /// </summary>
    /// <param name="n">The number of stones in the pile at the start of the game.</param>
    /// <returns><see langword="true" /> if the first player can force a win; otherwise, <see langword="false" />.</returns>
    bool CanWinNim(int n);
}