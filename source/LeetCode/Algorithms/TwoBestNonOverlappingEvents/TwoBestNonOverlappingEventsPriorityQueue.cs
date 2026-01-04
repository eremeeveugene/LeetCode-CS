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
public class TwoBestNonOverlappingEventsPriorityQueue : ITwoBestNonOverlappingEvents
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="events"></param>
    /// <returns></returns>
    public int MaxTwoEvents(int[][] events)
    {
        Array.Sort(events, (a, b) => a[0] - b[0]);

        var completedEventsPriorityQueue = new PriorityQueue<(int EndTime, int Value), int>();

        var maxValueBeforeCurrent = 0;
        var maxSum = 0;

        foreach (var @event in events)
        {
            var startTime = @event[0];
            var endTime = @event[1];
            var value = @event[2];

            while (completedEventsPriorityQueue.Count > 0 && completedEventsPriorityQueue.Peek().EndTime < startTime)
            {
                var completedEvent = completedEventsPriorityQueue.Dequeue();

                maxValueBeforeCurrent = Math.Max(maxValueBeforeCurrent, completedEvent.Value);
            }

            maxSum = Math.Max(maxSum, maxValueBeforeCurrent + value);

            completedEventsPriorityQueue.Enqueue((endTime, value), endTime);
        }

        return maxSum;
    }
}