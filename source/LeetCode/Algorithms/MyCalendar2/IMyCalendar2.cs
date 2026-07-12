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

namespace LeetCode.Algorithms.MyCalendar2;

/// <summary>
///     https://leetcode.com/problems/my-calendar-ii/
/// </summary>
public interface IMyCalendar2
{
    /// <summary>
    ///     Attempts to add a new event spanning the half-open interval [<paramref name="start" />,
    ///     <paramref name="end" />) to the calendar, succeeding as long as doing so would not create a triple
    ///     booking (three overlapping events).
    /// </summary>
    /// <param name="start">The start time of the event, inclusive.</param>
    /// <param name="end">The end time of the event, exclusive.</param>
    /// <returns><see langword="true" /> if the event was added without creating a triple booking; otherwise, <see langword="false" />.</returns>
    bool Book(int start, int end);
}