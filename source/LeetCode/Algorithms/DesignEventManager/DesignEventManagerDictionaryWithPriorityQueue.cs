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

namespace LeetCode.Algorithms.DesignEventManager;

/// <inheritdoc />
/// <remarks>
///     Tracks current event priorities and lazily removes outdated entries from the priority queue.
///     Space complexity - O(n + u), where n is the number of events and u is the number of priority updates
/// </remarks>
public sealed class DesignEventManagerDictionaryWithPriorityQueue : IDesignEventManager
{
    private static readonly Comparer<(int Priority, int EventId)> EventPriorityComparer =
        Comparer<(int Priority, int EventId)>.Create(static (left, right) =>
        {
            var priorityCompare = right.Priority.CompareTo(left.Priority);

            return priorityCompare == 0 ? left.EventId.CompareTo(right.EventId) : priorityCompare;
        });

    private readonly Dictionary<int, int> _eventIdToPriorityDictionary;
    private readonly PriorityQueue<int, (int Priority, int EventId)> _eventsPriorityQueue;

    /// <summary>
    ///     Initializes a new instance of the <see cref="DesignEventManagerDictionaryWithPriorityQueue" /> class.
    /// </summary>
    /// <param name="events">The initial events, where each event is [eventId, priority].</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public DesignEventManagerDictionaryWithPriorityQueue(int[][] events)
    {
        var n = events.Length;

        _eventIdToPriorityDictionary = new Dictionary<int, int>(n);

        var queuedEvents = new (int EventId, (int Priority, int EventId) EventPriority)[n];

        for (var i = 0; i < n; i++)
        {
            var eventId = events[i][0];
            var priority = events[i][1];

            _eventIdToPriorityDictionary.Add(eventId, priority);

            queuedEvents[i] = (eventId, (priority, eventId));
        }

        _eventsPriorityQueue = new PriorityQueue<int, (int Priority, int EventId)>(queuedEvents, EventPriorityComparer);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(n + u))
    ///     Space complexity - O(1)
    /// </remarks>
    public void UpdatePriority(int eventId, int newPriority)
    {
        _eventIdToPriorityDictionary[eventId] = newPriority;

        _eventsPriorityQueue.Enqueue(eventId, (newPriority, eventId));
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log(n + u))
    ///     Space complexity - O(1)
    /// </remarks>
    public int PollHighest()
    {
        while (_eventsPriorityQueue.TryDequeue(out var eventId, out var eventPriority))
        {
            if (!_eventIdToPriorityDictionary.TryGetValue(eventId, out var priority) || priority != eventPriority.Priority)
            {
                continue;
            }

            _eventIdToPriorityDictionary.Remove(eventId);

            return eventId;
        }

        return -1;
    }
}