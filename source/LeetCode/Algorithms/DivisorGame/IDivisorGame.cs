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

namespace LeetCode.Algorithms.DivisorGame;

/// <summary>
///     https://leetcode.com/problems/divisor-game/
/// </summary>
public interface IDivisorGame
{
    /// <summary>
    ///     Determines whether the first player can guarantee a win in the divisor game starting from <paramref name="n" />,
    ///     where players alternately replace <paramref name="n" /> with n minus a divisor smaller than n, and the player
    ///     unable to move loses.
    /// </summary>
    /// <param name="n">The starting number for the game.</param>
    /// <returns><see langword="true" /> if the first player wins with optimal play; otherwise, <see langword="false" />.</returns>
    bool DivisorGame(int n);
}