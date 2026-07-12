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

namespace LeetCode.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

/// <summary>
///     https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/description/
/// </summary>
public interface IWidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    /// <summary>
    ///     Finds the widest vertical area between any two points in <paramref name="points" /> that contains no
    ///     other point.
    /// </summary>
    /// <param name="points">The array of 2D points, each given as an x and y coordinate.</param>
    /// <returns>The width of the widest empty vertical area.</returns>
    int MaxWidthOfVerticalArea(int[][] points);
}