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

namespace LeetCode.Algorithms.MinimumNumberOfArrowsToBurstBalloons;

/// <inheritdoc />
public sealed class MinimumNumberOfArrowsToBurstBalloonsIterative : IMinimumNumberOfArrowsToBurstBalloons
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FindMinArrowShots(int[][] points)
    {
        var arrowShotsCount = 1;

        var orderedPoints = new int[points.Length][];

        Array.Copy(points, orderedPoints, points.Length);

        Array.Sort(orderedPoints, (a, b) => a[1].CompareTo(b[1]));

        var previousPoint = orderedPoints[0];

        for (var i = 0; i < orderedPoints.Length; i++)
        {
            var point = orderedPoints[i];

            if (point[0] <= previousPoint[1])
            {
                continue;
            }

            arrowShotsCount++;
            previousPoint = point;
        }

        return arrowShotsCount;
    }
}