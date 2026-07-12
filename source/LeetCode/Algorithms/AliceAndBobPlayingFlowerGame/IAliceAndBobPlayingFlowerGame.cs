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

namespace LeetCode.Algorithms.AliceAndBobPlayingFlowerGame;

/// <summary>
///     https://leetcode.com/problems/alice-and-bob-playing-flower-game/description/
/// </summary>
public interface IAliceAndBobPlayingFlowerGame
{
    /// <summary>
    ///     Counts the pairs (x, y) with x in the range [1, <paramref name="n" />] and y in the range
    ///     [1, <paramref name="m" />] such that Alice wins the flower game, i.e. x + y is odd.
    /// </summary>
    /// <param name="n">The number of flowers in the clockwise direction.</param>
    /// <param name="m">The number of flowers in the anti-clockwise direction.</param>
    /// <returns>The number of pairs (x, y) for which Alice wins the game.</returns>
    long FlowerGame(int n, int m);
}