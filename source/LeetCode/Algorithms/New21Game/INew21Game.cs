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

namespace LeetCode.Algorithms.New21Game;

/// <summary>
///     https://leetcode.com/problems/new-21-game/description/
/// </summary>
public interface INew21Game
{
    /// <summary>
    ///     Computes the probability that a player stopping the drawing game once their score reaches at least
    ///     <paramref name="k" /> ends up with a final score of <paramref name="n" /> or less, where each draw adds a
    ///     value from 1 to <paramref name="maxPts" /> chosen uniformly at random.
    /// </summary>
    /// <param name="n">The maximum score for the player to end up with.</param>
    /// <param name="k">The score threshold at or above which the player stops drawing.</param>
    /// <param name="maxPts">The maximum number of points that can be drawn in a single turn.</param>
    /// <returns>The probability that the player's final score is at most <paramref name="n" />.</returns>
    double New21Game(int n, int k, int maxPts);
}