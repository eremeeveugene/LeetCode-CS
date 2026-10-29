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

namespace LeetCode.Algorithms.FindTheNumberOfWaysToPlacePeople1;

/// <inheritdoc />
public sealed class FindTheNumberOfWaysToPlacePeople1BruteForce : IFindTheNumberOfWaysToPlacePeople1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfPairs(int[][] points)
    {
        var n = points.Length;

        var numberOfPairs = 0;

        for (var i = 0; i < n; i++)
        {
            var upperLeft = points[i];

            for (var j = 0; j < n; j++)
            {
                var lowerRight = points[j];

                if (i == j || upperLeft[0] > lowerRight[0] || upperLeft[1] < lowerRight[1])
                {
                    continue;
                }

                var isRectangleEmpty = IsRectangleEmpty(points, i, j);

                if (isRectangleEmpty)
                {
                    numberOfPairs++;
                }
            }
        }

        return numberOfPairs;
    }

    /// <summary>
    ///     Determines whether no point other than the two corners lies inside or on the boundary of the rectangle whose
    ///     upper-left corner is <c>points[upperLeftIndex]</c> and lower-right corner is <c>points[lowerRightIndex]</c>.
    /// </summary>
    /// <param name="points">The array of 2D points, each represented as a coordinate pair.</param>
    /// <param name="upperLeftIndex">The index of the upper-left corner.</param>
    /// <param name="lowerRightIndex">The index of the lower-right corner.</param>
    /// <returns>
    ///     <see langword="true" /> if the rectangle contains no other point; otherwise, <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsRectangleEmpty(int[][] points, int upperLeftIndex, int lowerRightIndex)
    {
        var upperLeft = points[upperLeftIndex];
        var lowerRight = points[lowerRightIndex];

        var n = points.Length;

        for (var k = 0; k < n; k++)
        {
            if (k == upperLeftIndex || k == lowerRightIndex)
            {
                continue;
            }

            var point = points[k];

            if (point[0] >= upperLeft[0] && point[0] <= lowerRight[0] && point[1] <= upperLeft[1] && point[1] >= lowerRight[1])
            {
                return false;
            }
        }

        return true;
    }
}