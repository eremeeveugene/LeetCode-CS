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

namespace LeetCode.Algorithms.TargetSum;

/// <summary>
///     https://leetcode.com/problems/target-sum/description/
/// </summary>
public interface ITargetSum
{
    /// <summary>
    ///     Counts the number of ways to assign a <c>+</c> or <c>-</c> sign to each element of <paramref name="nums" />
    ///     so that the resulting expression evaluates to <paramref name="target" />.
    /// </summary>
    /// <param name="nums">The array of non-negative integers to assign signs to.</param>
    /// <param name="target">The target sum the signed expression must evaluate to.</param>
    /// <returns>The number of ways to assign signs to reach <paramref name="target" />.</returns>
    int FindTargetSumWays(int[] nums, int target);
}