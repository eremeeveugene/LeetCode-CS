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

namespace LeetCode.Algorithms.TwoBestNonOverlappingEvents;

/// <inheritdoc />
public sealed class TwoBestNonOverlappingEventsBinarySearch : ITwoBestNonOverlappingEvents
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="events"></param>
    /// <returns></returns>
    public int MaxTwoEvents(int[][] events)
    {
        Array.Sort(events, (a, b) => a[1] - b[1]);

        var maxSum = 0;
        var maxValueBefore = new int[events.Length];
        var maxValueSoFar = 0;

        for (var i = 0; i < events.Length; i++)
        {
            var startTime = events[i][0];
            var value = events[i][2];

            var low = 0;
            var high = i - 1;
            var maxPreviousValue = 0;

            while (low <= high)
            {
                var mid = (low + high) / 2;

                if (events[mid][1] < startTime)
                {
                    maxPreviousValue = Math.Max(maxPreviousValue, maxValueBefore[mid]);

                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            maxSum = Math.Max(maxSum, maxPreviousValue + value);

            maxValueSoFar = Math.Max(maxValueSoFar, value);

            maxValueBefore[i] = maxValueSoFar;
        }

        return maxSum;
    }
}