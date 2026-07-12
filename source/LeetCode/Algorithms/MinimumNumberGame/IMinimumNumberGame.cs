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

namespace LeetCode.Algorithms.MinimumNumberGame;

/// <summary>
///     https://leetcode.com/problems/minimum-number-game/description/
/// </summary>
public interface IMinimumNumberGame
{
    /// <summary>
    ///     Simulates a game where Alice and Bob alternately remove the two smallest remaining numbers from
    ///     <paramref name="nums" /> (Bob's number is placed first, followed by Alice's) and builds the resulting
    ///     array.
    /// </summary>
    /// <param name="nums">The array of integers, of even length, used to play the game.</param>
    /// <returns>The array formed by the numbers in the order they were placed during the game.</returns>
    int[] NumberGame(int[] nums);
}