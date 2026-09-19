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
public sealed class CircleAndRectangleOverlappingDiametersAndCorners : ICircleAndRectangleOverlapping
{
    /// <inheritdoc />
    /// <remarks>
    ///     Checks the horizontal and vertical diameters, then the four rectangle corners.
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        return HorizontalDiameterOverlapsRectangle(radius, xCenter, yCenter, x1, y1, x2, y2) ||
               VerticalDiameterOverlapsRectangle(radius, xCenter, yCenter, x1, y1, x2, y2) ||
               IsPointInsideCircle(radius, xCenter, yCenter, x1, y1) ||
               IsPointInsideCircle(radius, xCenter, yCenter, x1, y2) ||
               IsPointInsideCircle(radius, xCenter, yCenter, x2, y1) ||
               IsPointInsideCircle(radius, xCenter, yCenter, x2, y2);
    }

    /// <summary>
    ///     Determines whether the circle's horizontal diameter intersects the rectangle.
    /// </summary>
    private static bool HorizontalDiameterOverlapsRectangle(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        var leftX = xCenter - radius;
        var rightX = xCenter + radius;

        return rightX >= x1 && leftX <= x2 && yCenter >= y1 && yCenter <= y2;
    }

    /// <summary>
    ///     Determines whether the circle's vertical diameter intersects the rectangle.
    /// </summary>
    private static bool VerticalDiameterOverlapsRectangle(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        var topY = yCenter + radius;
        var bottomY = yCenter - radius;

        return topY >= y1 && bottomY <= y2 && xCenter >= x1 && xCenter <= x2;
    }

    /// <summary>
    ///     Determines whether a rectangle corner is inside or on the circle.
    /// </summary>
    private static bool IsPointInsideCircle(int radius, int xCenter, int yCenter, int x, int y)
    {
        var horizontalDistance = xCenter - x;
        var verticalDistance = yCenter - y;

        var horizontalDistanceSquared = horizontalDistance * horizontalDistance;
        var verticalDistanceSquared = verticalDistance * verticalDistance;
        var distanceSquared = horizontalDistanceSquared + verticalDistanceSquared;
        var radiusSquared = radius * radius;

        return distanceSquared <= radiusSquared;
    }
}