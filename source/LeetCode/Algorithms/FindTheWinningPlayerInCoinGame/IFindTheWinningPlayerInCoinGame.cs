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

namespace LeetCode.Algorithms.FindTheWinningPlayerInCoinGame;

/// <summary>
///     https://leetcode.com/problems/find-the-winning-player-in-coin-game/description/
/// </summary>
public interface IFindTheWinningPlayerInCoinGame
{
    /// <summary>
    ///     Determines the winner of the coin game in which Alice and Bob alternately pick coins with a total value of 115
    ///     (one 75-value coin and four 10-value coins per turn), given <paramref name="x" /> coins of value 75 and
    ///     <paramref name="y" /> coins of value 10.
    /// </summary>
    /// <param name="x">The number of coins with a value of 75.</param>
    /// <param name="y">The number of coins with a value of 10.</param>
    /// <returns>The name of the winning player, either "Alice" or "Bob".</returns>
    string WinningPlayer(int x, int y);
}