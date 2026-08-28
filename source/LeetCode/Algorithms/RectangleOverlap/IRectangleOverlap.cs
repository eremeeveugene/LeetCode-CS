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

namespace LeetCode.Algorithms.RectangleOverlap;

/// <summary>
///     https://leetcode.com/problems/rectangle-overlap/description/
/// </summary>
public interface IRectangleOverlap
{
    /// <summary>
    ///     Determines whether two axis-aligned rectangles have an intersection with positive area.
    /// </summary>
    /// <param name="rec1">The first rectangle as [x1, y1, x2, y2].</param>
    /// <param name="rec2">The second rectangle as [x1, y1, x2, y2].</param>
    /// <returns><c>true</c> when the rectangles overlap with positive area; otherwise, <c>false</c>.</returns>
    bool IsRectangleOverlap(int[] rec1, int[] rec2);
}