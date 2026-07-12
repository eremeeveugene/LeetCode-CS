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

namespace LeetCode.Algorithms.RescheduleMeetingsForMaximumFreeTime1;

/// <summary>
///     https://leetcode.com/problems/reschedule-meetings-for-maximum-free-time-i/description/
/// </summary>
public interface IRescheduleMeetingsForMaximumFreeTime1
{
    /// <summary>
    ///     Determines the maximum continuous free time achievable within an event of length <paramref name="eventTime" />
    ///     by rescheduling at most <paramref name="k" /> of the meetings described by <paramref name="startTime" /> and
    ///     <paramref name="endTime" />, keeping each meeting's duration and preventing overlaps.
    /// </summary>
    /// <param name="eventTime">The total length of the event during which meetings take place.</param>
    /// <param name="k">The maximum number of meetings that may be rescheduled.</param>
    /// <param name="startTime">The start time of each meeting.</param>
    /// <param name="endTime">The end time of each meeting.</param>
    /// <returns>The maximum length of continuous free time obtainable after rescheduling.</returns>
    int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime);
}