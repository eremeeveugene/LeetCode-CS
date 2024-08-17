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

namespace LeetCode.Algorithms.MaximumNumberOfPointsWithCost;

/// <inheritdoc />
public class MaximumNumberOfPointsWithCostDynamicProgramming : IMaximumNumberOfPointsWithCost
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="points"></param>
    /// <returns></returns>
    public long MaxPoints(int[][] points)
    {
        var scores = new long[points[0].Length];

        for (var j = 0; j < points[0].Length; j++)
        {
            scores[j] = points[0][j];
        }

        for (var i = 1; i < points.Length; i++)
        {
            var leftMax = new long[points[i].Length];
            var rightMax = new long[points[i].Length];

            leftMax[0] = scores[0];

            for (var j = 1; j < points[i].Length; j++)
            {
                leftMax[j] = Math.Max(leftMax[j - 1], scores[j] + j);
            }

            rightMax[points[i].Length - 1] = scores[points[i].Length - 1] - (points[i].Length - 1);

            for (var j = points[i].Length - 2; j >= 0; j--)
            {
                rightMax[j] = Math.Max(rightMax[j + 1], scores[j] - j);
            }

            for (var j = 0; j < points[i].Length; j++)
            {
                scores[j] = points[i][j] + Math.Max(leftMax[j] - j, rightMax[j] + j);
            }
        }

        return scores.Max();
    }
}