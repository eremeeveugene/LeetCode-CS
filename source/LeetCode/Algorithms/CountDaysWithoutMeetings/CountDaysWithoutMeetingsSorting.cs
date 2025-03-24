// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CountDaysWithoutMeetings;

/// <inheritdoc />
public class CountDaysWithoutMeetingsSorting : ICountDaysWithoutMeetings
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="days"></param>
    /// <param name="meetings"></param>
    /// <returns></returns>
    public int CountDays(int days, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        var result = 0;

        var previous = 1;

        foreach (var meeting in meetings)
        {
            var start = meeting[0];
            var end = meeting[1];

            if (start > previous)
            {
                result += start - previous;
            }

            previous = Math.Max(previous, end + 1);
        }

        if (previous <= days)
        {
            result += days - previous + 1;
        }

        return result;
    }
}