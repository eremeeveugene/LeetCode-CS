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

namespace LeetCode.Algorithms.WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

/// <inheritdoc />
public class
    WidestVerticalAreaBetweenTwoPointsContainingNoPointsDescending :
    IWidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    /// <summary>
    ///     Time complexity - O(n log n)
    /// </summary>
    /// <param name="points"></param>
    /// <returns></returns>
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var xValues = points.Select(p => p[0]).ToArray();

        Array.Sort(xValues);

        var maxWidth = 0;

        for (var i = 0; i < xValues.Length - 1; i++)
        {
            var width = xValues[i] - xValues[i + 1];

            if (width > maxWidth)
            {
                maxWidth = width;
            }
        }

        return maxWidth;
    }
}