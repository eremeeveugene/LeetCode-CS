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

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended/description/
/// </summary>
public interface IMaximumNumberOfEventsThatCanBeAttended
{
    /// <summary>
    ///     Determines the maximum number of events from <paramref name="events" /> that can be attended, where each
    ///     event can be attended on any single day within its [startDay, endDay] range and at most one event may be
    ///     attended per day.
    /// </summary>
    /// <param name="events">The array of events, where each element is a [startDay, endDay] pair.</param>
    /// <returns>The maximum number of events that can be attended.</returns>
    int MaxEvents(int[][] events);
}