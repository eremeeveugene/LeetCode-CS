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

namespace LeetCode.Algorithms.CircleAndRectangleOverlapping;

/// <summary>
///     https://leetcode.com/problems/circle-and-rectangle-overlapping/description/
/// </summary>
public interface ICircleAndRectangleOverlapping
{
    /// <summary>
    ///     Determines whether a circle and an axis-aligned rectangle have at least one point in common.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="xCenter">The x-coordinate of the circle's center.</param>
    /// <param name="yCenter">The y-coordinate of the circle's center.</param>
    /// <param name="x1">The x-coordinate of the rectangle's bottom-left corner.</param>
    /// <param name="y1">The y-coordinate of the rectangle's bottom-left corner.</param>
    /// <param name="x2">The x-coordinate of the rectangle's top-right corner.</param>
    /// <param name="y2">The y-coordinate of the rectangle's top-right corner.</param>
    /// <returns><c>true</c> if the circle and rectangle overlap; otherwise, <c>false</c>.</returns>
    bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2);
}