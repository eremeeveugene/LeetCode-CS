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

namespace LeetCode.Algorithms.NumberOfIntersectingIntervalPairs1;

/// <inheritdoc />
public sealed class NumberOfIntersectingIntervalPairs1LineSweep : INumberOfIntersectingIntervalPairs1
{
    private const int MaxCoordinate = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m), where m is the maximum coordinate
    ///     Space complexity - O(m)
    /// </remarks>
    public int CountIntersectingIntervals(int[][] intervals)
    {
        var n = intervals.Length;

        Span<int> startCounts = stackalloc int[MaxCoordinate + 1];
        Span<int> endCounts = stackalloc int[MaxCoordinate + 1];

        for (var i = 0; i < n; i++)
        {
            var interval = intervals[i];
            var start = interval[0];
            var end = interval[1];

            startCounts[start]++;
            endCounts[end]++;
        }

        var count = 0;

        var activeCount = 0;

        for (var point = 0; point <= MaxCoordinate; point++)
        {
            var startCount = startCounts[point];

            count += (startCount * activeCount) + (startCount * (startCount - 1) / 2);

            activeCount += startCount;

            activeCount -= endCounts[point];
        }

        return count;
    }
}