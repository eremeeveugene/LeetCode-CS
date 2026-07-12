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

namespace LeetCode.Algorithms.LargestTriangleArea;

/// <summary>
///     https://leetcode.com/problems/largest-triangle-area/description/
/// </summary>
public interface ILargestTriangleArea
{
    /// <summary>
    ///     Finds the largest possible area of a triangle formed by any three of the points in <paramref name="points" />.
    /// </summary>
    /// <param name="points">The array of 2D points, each represented as a coordinate pair.</param>
    /// <returns>The largest triangle area attainable from any three points.</returns>
    double LargestTriangleArea(int[][] points);
}