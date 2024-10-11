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

namespace LeetCode.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

/// <inheritdoc />
public class TheNumberOfTheSmallestUnoccupiedChairSortedSet : ITheNumberOfTheSmallestUnoccupiedChair
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="times"></param>
    /// <param name="targetFriend"></param>
    /// <returns></returns>
    public int SmallestChair(int[][] times, int targetFriend)
    {
        var freeChairs = new SortedSet<int>();

        for (var i = 0; i < times.Length; i++)
        {
            freeChairs.Add(i);
        }

        var chairAssigned = new int[times.Length];

        var events = new List<Event>();

        for (var i = 0; i < times.Length; i++)
        {
            events.Add(new Event(times[i][0], i, true));
            events.Add(new Event(times[i][1], i, false));
        }

        events.Sort();

        foreach (var @event in events)
        {
            if (@event.IsArrival)
            {
                var assignedChair = freeChairs.Min;

                freeChairs.Remove(assignedChair);

                chairAssigned[@event.FriendId] = assignedChair;

                if (@event.FriendId == targetFriend)
                {
                    return assignedChair;
                }
            }
            else
            {
                freeChairs.Add(chairAssigned[@event.FriendId]);
            }
        }

        return -1;
    }

    private class Event(int time, int friendId, bool isArrival) : IComparable<Event>
    {
        private readonly int _time = time;
        public int FriendId { get; } = friendId;
        public bool IsArrival { get; } = isArrival;

        public int CompareTo(Event? other)
        {
            if (other == null)
            {
                return -1;
            }

            var timeComparison = _time.CompareTo(other._time);

            return timeComparison == 0 ? IsArrival.CompareTo(other.IsArrival) : timeComparison;
        }
    }
}