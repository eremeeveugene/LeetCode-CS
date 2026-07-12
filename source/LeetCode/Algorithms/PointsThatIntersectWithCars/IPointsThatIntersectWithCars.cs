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

namespace LeetCode.Algorithms.PointsThatIntersectWithCars;

/// <summary>
///     https://leetcode.com/problems/points-that-intersect-with-cars/description/
/// </summary>
public interface IPointsThatIntersectWithCars
{
    /// <summary>
    ///     Counts the number of distinct integer points on the road that are covered by at least one of the car ranges
    ///     given in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The list of car ranges, each expressed as a pair of start and end points, inclusive.</param>
    /// <returns>The number of distinct points covered by at least one car.</returns>
    int NumberOfPoints(IList<IList<int>> nums);
}