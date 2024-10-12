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

namespace LeetCode.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;

/// <inheritdoc />
public class DivideIntervalsIntoMinimumNumberOfGroupsLineSweep : IDivideIntervalsIntoMinimumNumberOfGroups
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="intervals"></param>
    /// <returns></returns>
    public int MinGroups(int[][] intervals)
    {
        var rangeStart = int.MaxValue;
        var rangeEnd = int.MinValue;

        foreach (var interval in intervals)
        {
            rangeStart = Math.Min(rangeStart, interval[0]);
            rangeEnd = Math.Max(rangeEnd, interval[1]);
        }

        var pointToCount = new int[rangeEnd + 2];

        foreach (var interval in intervals)
        {
            pointToCount[interval[0]]++;
            pointToCount[interval[1] + 1]--;
        }

        var concurrentIntervals = 0;
        var maxConcurrentIntervals = 0;

        for (var i = rangeStart; i <= rangeEnd; i++)
        {
            concurrentIntervals += pointToCount[i];

            maxConcurrentIntervals = Math.Max(maxConcurrentIntervals, concurrentIntervals);
        }

        return maxConcurrentIntervals;
    }
}