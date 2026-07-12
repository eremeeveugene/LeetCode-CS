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

namespace LeetCode.Algorithms.CanIWin;

/// <summary>
///     https://leetcode.com/problems/can-i-win/
/// </summary>
public interface ICanIWin
{
    /// <summary>
    ///     Determines whether the first player can force a win in the 100 game, where players alternately pick distinct
    ///     integers from 1 to <paramref name="maxChoosableInteger" /> and the player who first reaches or exceeds
    ///     <paramref name="desiredTotal" /> wins.
    /// </summary>
    /// <param name="maxChoosableInteger">The largest integer that can be chosen.</param>
    /// <param name="desiredTotal">The running total to reach or exceed.</param>
    /// <returns><c>true</c> if the first player can force a win with optimal play; otherwise, <c>false</c>.</returns>
    bool CanIWin(int maxChoosableInteger, int desiredTotal);
}