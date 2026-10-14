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

namespace LeetCode.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

/// <inheritdoc />
public sealed class WidestVerticalAreaBetweenTwoPointsContainingNoPointsAscending : IWidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var xValues = new int[points.Length];

        for (var i = 0; i < points.Length; i++)
        {
            xValues[i] = points[i][0];
        }

        Array.Sort(xValues);

        var maxWidth = 0;

        for (var i = 1; i < xValues.Length; i++)
        {
            var width = xValues[i] - xValues[i - 1];

            if (width > maxWidth)
            {
                maxWidth = width;
            }
        }

        return maxWidth;
    }
}