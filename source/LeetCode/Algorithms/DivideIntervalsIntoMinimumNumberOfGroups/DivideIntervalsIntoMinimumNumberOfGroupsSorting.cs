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
public class DivideIntervalsIntoMinimumNumberOfGroupsSorting : IDivideIntervalsIntoMinimumNumberOfGroups
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="intervals"></param>
    /// <returns></returns>
    public int MinGroups(int[][] intervals)
    {
        var events = new List<(int Time, int Type)>();

        foreach (var interval in intervals)
        {
            events.Add((interval[0], 1));
            events.Add((interval[1], -1));
        }

        events.Sort((a, b) => a.Time == b.Time ? b.Type.CompareTo(a.Type) : a.Time.CompareTo(b.Time));

        var minGroups = 0;
        var activeIntervals = 0;

        for (var i = 0; i < events.Count; i++)
        {
            activeIntervals += events[i].Type;

            minGroups = Math.Max(minGroups, activeIntervals);
        }

        return minGroups;
    }
}