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

namespace LeetCode.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;

/// <inheritdoc />
public sealed class DivideIntervalsIntoMinimumNumberOfGroupsLineSweep : IDivideIntervalsIntoMinimumNumberOfGroups
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinGroups(int[][] intervals)
    {
        var rangeStart = int.MaxValue;
        var rangeEnd = int.MinValue;

        for (var i = 0; i < intervals.Length; i++)
        {
            var interval = intervals[i];

            rangeStart = Math.Min(rangeStart, interval[0]);
            rangeEnd = Math.Max(rangeEnd, interval[1]);
        }

        var pointToCount = new int[rangeEnd + 2];

        for (var i = 0; i < intervals.Length; i++)
        {
            var interval = intervals[i];

            pointToCount[interval[0]]++;
            pointToCount[interval[1] + 1]--;
        }

        var concurrentIntervals = 0;
        var maxConcurrentIntervals = 0;

        for (var point = rangeStart; point <= rangeEnd; point++)
        {
            concurrentIntervals += pointToCount[point];

            maxConcurrentIntervals = Math.Max(maxConcurrentIntervals, concurrentIntervals);
        }

        return maxConcurrentIntervals;
    }
}