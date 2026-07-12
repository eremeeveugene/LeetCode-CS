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

namespace LeetCode.Algorithms.DetermineIfTwoEventsHaveConflict;

/// <summary>
///     https://leetcode.com/problems/determine-if-two-events-have-conflict/description/
/// </summary>
public interface IDetermineIfTwoEventsHaveConflict
{
    /// <summary>
    ///     Determines whether the two events have a time conflict, i.e. whether their time intervals intersect.
    /// </summary>
    /// <param name="event1">The first event as a pair of start and end times in "HH:MM" format.</param>
    /// <param name="event2">The second event as a pair of start and end times in "HH:MM" format.</param>
    /// <returns><c>true</c> if the two events overlap in time; otherwise, <c>false</c>.</returns>
    bool HaveConflict(string[] event1, string[] event2);
}