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

namespace LeetCode.Algorithms.CountDaysWithoutMeetings;

/// <summary>
///     https://leetcode.com/problems/count-days-without-meetings/description/
/// </summary>
public interface ICountDaysWithoutMeetings
{
    /// <summary>
    ///     Counts the days in the range from 1 to <paramref name="days" /> on which no meeting from
    ///     <paramref name="meetings" /> is scheduled.
    /// </summary>
    /// <param name="days">The total number of days an employee is available for work.</param>
    /// <param name="meetings">The meetings, where each element is an inclusive interval [start, end] of days.</param>
    /// <returns>The number of days without any scheduled meeting.</returns>
    int CountDays(int days, int[][] meetings);
}