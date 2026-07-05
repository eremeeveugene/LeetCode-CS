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

namespace LeetCode.Algorithms.MinimumScoreOfAPathBetweenTwoCities;

/// <summary>
///     https://leetcode.com/problems/minimum-score-of-a-path-between-two-cities/description/
/// </summary>
public interface IMinimumScoreOfAPathBetweenTwoCities
{
    /// <summary>
    ///     Finds the minimum possible score of a path between city 1 and city <paramref name="n" />, where the score of a
    ///     path is the minimum distance among all roads travelled and a path may revisit cities and roads.
    /// </summary>
    /// <param name="n">The number of cities, labeled from 1 to <paramref name="n" />.</param>
    /// <param name="roads">
    ///     The array of roads, where each road is represented as [a, b, distance] and connects cities a and b with a
    ///     bidirectional road of the given distance.
    /// </param>
    /// <returns>The minimum possible score of a path between city 1 and city <paramref name="n" />.</returns>
    int MinScore(int n, int[][] roads);
}