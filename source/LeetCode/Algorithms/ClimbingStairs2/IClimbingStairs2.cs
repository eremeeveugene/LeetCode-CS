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

namespace LeetCode.Algorithms.ClimbingStairs2;

/// <summary>
///     https://leetcode.com/problems/climbing-stairs-ii/description/
/// </summary>
public interface IClimbingStairs2
{
    /// <summary>
    ///     Finds the minimum total cost to climb from step 0 to step <paramref name="n" /> in jumps of up to three
    ///     steps, where a jump from step i to step j is priced at costs[j] + (j - i)^2.
    /// </summary>
    /// <param name="n">The number of the top step.</param>
    /// <param name="costs">The 1-indexed costs of steps 1 to <paramref name="n" />.</param>
    /// <returns>The minimum total cost to reach step <paramref name="n" />.</returns>
    int ClimbStairs(int n, int[] costs);
}