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

namespace LeetCode.Algorithms.NumberOfIntersectingIntervalPairs2;

/// <inheritdoc />
public sealed class NumberOfIntersectingIntervalPairs2BinarySearch : INumberOfIntersectingIntervalPairs2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public long CountIntersectingIntervals(int[][] intervals)
    {
        var n = intervals.Length;

        Array.Sort(intervals, (first, second) => first[0].CompareTo(second[0]));

        long result = 0;

        for (var i = 0; i < n; i++)
        {
            var interval = intervals[i];
            var intervalEnd = interval[1];

            var startIndex = i + 1;
            var endIndex = UpperBound(intervals, startIndex, n, intervalEnd);

            result += endIndex - startIndex;
        }

        return result;
    }

    /// <summary>
    ///     Finds the first interval whose start is greater than the target within the given range.
    /// </summary>
    /// <param name="intervals">The intervals sorted by start.</param>
    /// <param name="left">The inclusive index to start searching from.</param>
    /// <param name="right">The exclusive index to stop searching at.</param>
    /// <param name="target">The value the interval start is compared against.</param>
    /// <returns>The index of the first interval with a start greater than the target, or <paramref name="right" /> if there is none.</returns>
    private static int UpperBound(int[][] intervals, int left, int right, int target)
    {
        while (left < right)
        {
            var middle = left + ((right - left) / 2);

            var middleStart = intervals[middle][0];

            if (middleStart > target)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }
}