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

namespace LeetCode.Algorithms.MaximumNumberOfEventsThatCanBeAttended;

/// <inheritdoc />
public sealed class MaximumNumberOfEventsThatCanBeAttendedPriorityQueue : IMaximumNumberOfEventsThatCanBeAttended
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaxEvents(int[][] events)
    {
        Array.Sort(events, (event1, event2) => event1[0] - event2[0]);

        var maxEvents = 0;

        var priorityQueue = new PriorityQueue<int, int>();

        var eventIndex = 0;

        var day = 0;

        while (eventIndex < events.Length || priorityQueue.Count > 0)
        {
            while (eventIndex < events.Length && events[eventIndex][0] <= day)
            {
                priorityQueue.Enqueue(events[eventIndex][1], events[eventIndex][1]);

                eventIndex++;
            }

            while (priorityQueue.Count > 0 && priorityQueue.Peek() < day)
            {
                priorityQueue.Dequeue();
            }

            if (priorityQueue.Count > 0)
            {
                priorityQueue.Dequeue();

                maxEvents++;
            }

            day++;
        }

        return maxEvents;
    }
}