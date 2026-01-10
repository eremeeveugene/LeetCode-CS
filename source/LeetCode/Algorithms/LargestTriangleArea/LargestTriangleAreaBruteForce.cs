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

namespace LeetCode.Algorithms.LargestTriangleArea;

/// <inheritdoc />
public sealed class LargestTriangleAreaBruteForce : ILargestTriangleArea
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="points"></param>
    /// <returns></returns>
    public double LargestTriangleArea(int[][] points)
    {
        var maxArea = 0.0;

        var pointsLength = points.Length;

        for (var i = 0; i < pointsLength - 2; i++)
        {
            var a = points[i];

            var aX = a[0];
            var aY = a[1];

            for (var j = i + 1; j < pointsLength - 1; j++)
            {
                var b = points[j];

                var bX = b[0];
                var bY = b[1];

                for (var k = j + 1; k < pointsLength; k++)
                {
                    var c = points[k];

                    var cX = c[0];
                    var cY = c[1];

                    var area = CalculateArea(aX, aY, bX, bY, cX, cY);

                    maxArea = double.Max(maxArea, area);
                }
            }
        }

        return maxArea;
    }

    private static double CalculateArea(int aX, int aY, int bX, int bY, int cX, int cY)
    {
        return int.Abs((aX * (bY - cY)) + (bX * (cY - aY)) + (cX * (aY - bY))) / 2.0;
    }
}