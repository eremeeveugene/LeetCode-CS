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

namespace LeetCode.Algorithms.NumberOfIntersectingIntervalPairs1;

/// <summary>
///     https://leetcode.com/problems/number-of-intersecting-interval-pairs-i/description/
/// </summary>
public interface INumberOfIntersectingIntervalPairs1
{
    /// <summary>
    ///     Counts the pairs of indices whose closed intervals share at least one point.
    /// </summary>
    /// <param name="intervals">The array of closed intervals, each given as a start and an end.</param>
    /// <returns>The number of intersecting interval pairs.</returns>
    int CountIntersectingIntervals(int[][] intervals);
}