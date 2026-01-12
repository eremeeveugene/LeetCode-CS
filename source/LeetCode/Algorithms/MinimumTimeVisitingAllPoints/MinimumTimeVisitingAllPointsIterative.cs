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

namespace LeetCode.Algorithms.MinimumTimeVisitingAllPoints;

/// <inheritdoc />
public sealed class MinimumTimeVisitingAllPointsIterative : IMinimumTimeVisitingAllPoints
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="points"></param>
    /// <returns></returns>
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        var result = 0;

        for (var i = 0; i < points.Length - 1; i++)
        {
            var point = points[i];
            var nextPoint = points[i + 1];

            var dx = Math.Abs(nextPoint[0] - point[0]);
            var dy = Math.Abs(nextPoint[1] - point[1]);

            result += Math.Max(dx, dy);
        }

        return result;
    }
}