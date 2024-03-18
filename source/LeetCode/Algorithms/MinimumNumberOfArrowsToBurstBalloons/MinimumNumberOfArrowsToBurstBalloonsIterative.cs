// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class MinimumNumberOfArrowsToBurstBalloonsIterative : IMinimumNumberOfArrowsToBurstBalloons
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="points"></param>
    /// <returns></returns>
    public int FindMinArrowShots(int[][] points)
    {
        var arrowShotsCount = 1;

        var orderedPoints = points.OrderBy(p => p[1]).ToArray();

        var previousPoint = orderedPoints[0];

        foreach (var point in orderedPoints)
        {
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