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

namespace LeetCode.Algorithms.MinimumTotalDistanceTraveled;

/// <summary>
///     https://leetcode.com/problems/minimum-total-distance-traveled/description/
/// </summary>
public interface IMinimumTotalDistanceTraveled
{
    /// <summary>
    ///     Finds the minimum total distance the robots travel so that every robot is repaired by a factory
    ///     without exceeding any factory's limit.
    /// </summary>
    /// <param name="robot">The positions of the robots on the X-axis.</param>
    /// <param name="factory">The factories, each given as [position, limit].</param>
    /// <returns>The minimum total distance traveled by all the robots.</returns>
    long MinimumTotalDistance(IList<int> robot, int[][] factory);
}