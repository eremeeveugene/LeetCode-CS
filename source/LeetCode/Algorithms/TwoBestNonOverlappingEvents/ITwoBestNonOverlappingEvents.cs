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

namespace LeetCode.Algorithms.TwoBestNonOverlappingEvents;

/// <summary>
///     https://leetcode.com/problems/two-best-non-overlapping-events/description/
/// </summary>
public interface ITwoBestNonOverlappingEvents
{
    /// <summary>
    ///     Finds the maximum sum of values obtainable by attending at most two non-overlapping events from
    ///     <paramref name="events" />.
    /// </summary>
    /// <param name="events">The array of events, each given as a start time, end time, and value.</param>
    /// <returns>The maximum sum of values from at most two non-overlapping events.</returns>
    int MaxTwoEvents(int[][] events);
}