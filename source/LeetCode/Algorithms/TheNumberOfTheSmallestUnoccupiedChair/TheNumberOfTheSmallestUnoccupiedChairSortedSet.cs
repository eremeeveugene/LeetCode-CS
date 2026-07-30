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

namespace LeetCode.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

/// <inheritdoc />
public sealed class TheNumberOfTheSmallestUnoccupiedChairSortedSet : ITheNumberOfTheSmallestUnoccupiedChair
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int SmallestChair(int[][] times, int targetFriend)
    {
        var freeChairs = new SortedSet<int>();

        for (var i = 0; i < times.Length; i++)
        {
            freeChairs.Add(i);
        }

        var chairAssigned = new int[times.Length];

        var events = new List<(int Time, int FriendId, bool IsArrival)>();

        for (var i = 0; i < times.Length; i++)
        {
            events.Add((times[i][0], i, true));
            events.Add((times[i][1], i, false));
        }

        events.Sort((left, right) => left.Time != right.Time ? left.Time.CompareTo(right.Time) : left.IsArrival.CompareTo(right.IsArrival));

        var result = -1;

        foreach (var @event in events)
        {
            if (@event.IsArrival)
            {
                var assignedChair = freeChairs.Min;

                freeChairs.Remove(assignedChair);

                chairAssigned[@event.FriendId] = assignedChair;

                if (@event.FriendId != targetFriend)
                {
                    continue;
                }

                result = assignedChair;

                break;
            }

            freeChairs.Add(chairAssigned[@event.FriendId]);
        }

        return result;
    }
}