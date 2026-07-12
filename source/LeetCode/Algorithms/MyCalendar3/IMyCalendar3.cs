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

namespace LeetCode.Algorithms.MyCalendar3;

/// <summary>
///     https://leetcode.com/problems/my-calendar-iii/description/
/// </summary>
public interface IMyCalendar3
{
    /// <summary>
    ///     Adds a new event spanning the half-open interval [<paramref name="startTime" />,
    ///     <paramref name="endTime" />) to the calendar and returns the maximum k-booking achieved so far, where a
    ///     k-booking is a time point covered by k or more overlapping events.
    /// </summary>
    /// <param name="startTime">The start time of the event, inclusive.</param>
    /// <param name="endTime">The end time of the event, exclusive.</param>
    /// <returns>The maximum number of overlapping events at any single point in time after adding the new event.</returns>
    int Book(int startTime, int endTime);
}