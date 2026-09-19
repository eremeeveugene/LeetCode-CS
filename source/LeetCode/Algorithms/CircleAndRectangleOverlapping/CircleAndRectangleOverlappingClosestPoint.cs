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

/// <inheritdoc />
public sealed class CircleAndRectangleOverlappingClosestPoint : ICircleAndRectangleOverlapping
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        var closestX = Math.Clamp(xCenter, x1, x2);
        var closestY = Math.Clamp(yCenter, y1, y2);

        var deltaX = xCenter - closestX;
        var deltaY = yCenter - closestY;

        return (deltaX * deltaX) + (deltaY * deltaY) <= radius * radius;
    }
}