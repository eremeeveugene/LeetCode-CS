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

namespace LeetCode.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

/// <summary>
///     https://leetcode.com/problems/shortest-distance-after-road-addition-queries-i/description/
/// </summary>
public interface IShortestDistanceAfterRoadAdditionQueries1
{
    /// <summary>
    ///     Computes, after adding each unidirectional road described in <paramref name="queries" /> one at a
    ///     time to a path graph of <paramref name="n" /> cities, the shortest distance from city 0 to city
    ///     n - 1.
    /// </summary>
    /// <param name="n">The number of cities, numbered from 0 to n - 1.</param>
    /// <param name="queries">The array of roads to add, each specifying a source and destination city.</param>
    /// <returns>An array where each element is the shortest distance from city 0 to city n - 1 after the corresponding road is added.</returns>
    int[] ShortestDistanceAfterQueries(int n, int[][] queries);
}