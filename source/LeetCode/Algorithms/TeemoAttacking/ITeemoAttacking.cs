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

namespace LeetCode.Algorithms.TeemoAttacking;

/// <summary>
///     https://leetcode.com/problems/teemo-attacking/description/
/// </summary>
public interface ITeemoAttacking
{
    /// <summary>
    ///     Computes the total number of seconds that a target is poisoned, given the attack timestamps in
    ///     <paramref name="timeSeries" /> and the poison <paramref name="duration" /> applied by each attack.
    /// </summary>
    /// <param name="timeSeries">The sorted array of timestamps at which an attack occurs.</param>
    /// <param name="duration">The number of seconds the target remains poisoned after each attack.</param>
    /// <returns>The total number of seconds the target is poisoned.</returns>
    int FindPoisonedDuration(int[] timeSeries, int duration);
}