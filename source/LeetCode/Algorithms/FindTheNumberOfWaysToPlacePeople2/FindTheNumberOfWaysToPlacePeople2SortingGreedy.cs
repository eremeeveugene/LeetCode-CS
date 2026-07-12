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

namespace LeetCode.Algorithms.FindTheNumberOfWaysToPlacePeople2;

/// <inheritdoc />
public sealed class FindTheNumberOfWaysToPlacePeople2SortingGreedy : IFindTheNumberOfWaysToPlacePeople2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int NumberOfPairs(int[][] points)
    {
        Array.Sort(points, PointsComparison);

        var n = points.Length;

        var numberOfPairs = 0;

        for (var i = n - 1; i >= 1; i--)
        {
            var y1 = points[i][1];

            var minY = int.MaxValue;

            for (var j = i - 1; j >= 0; j--)
            {
                var y2 = points[j][1];

                if (y2 < y1 || y2 >= minY)
                {
                    continue;
                }

                minY = y2;

                numberOfPairs++;
            }
        }

        return numberOfPairs;
    }

    private static int PointsComparison(int[] a, int[] b)
    {
        var xComparison = a[0].CompareTo(b[0]);

        return xComparison == 0 ? b[1].CompareTo(a[1]) : xComparison;
    }
}