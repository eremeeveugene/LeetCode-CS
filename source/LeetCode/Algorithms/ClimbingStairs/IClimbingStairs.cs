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

namespace LeetCode.Algorithms.ClimbingStairs;

/// <summary>
///     https://leetcode.com/problems/climbing-stairs/
/// </summary>
public interface IClimbingStairs
{
    /// <summary>
    ///     Counts the distinct ways to climb a staircase of <paramref name="n" /> steps, taking either 1 or 2 steps at a
    ///     time.
    /// </summary>
    /// <param name="n">The total number of steps in the staircase.</param>
    /// <returns>The number of distinct ways to reach the top.</returns>
    int ClimbStairs(int n);
}