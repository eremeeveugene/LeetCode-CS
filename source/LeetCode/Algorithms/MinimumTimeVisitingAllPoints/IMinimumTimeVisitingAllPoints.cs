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

namespace LeetCode.Algorithms.MinimumTimeVisitingAllPoints;

/// <summary>
///     https://leetcode.com/problems/minimum-time-visiting-all-points/description/
/// </summary>
public interface IMinimumTimeVisitingAllPoints
{
    /// <summary>
    ///     Finds the minimum time, in seconds, needed to visit all the points in <paramref name="points" /> in the
    ///     given order, moving one unit per second in any of the eight compass directions.
    /// </summary>
    /// <param name="points">The ordered list of 2D points, each represented as a two-element coordinate array.</param>
    /// <returns>The minimum number of seconds required to visit all points in order.</returns>
    int MinTimeToVisitAllPoints(int[][] points);
}