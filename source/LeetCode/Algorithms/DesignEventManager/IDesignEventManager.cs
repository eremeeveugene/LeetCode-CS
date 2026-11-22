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

namespace LeetCode.Algorithms.DesignEventManager;

/// <summary>
///     https://leetcode.com/problems/design-event-manager/description/
/// </summary>
public interface IDesignEventManager
{
    /// <summary>
    ///     Updates the priority of the active event with the given identifier.
    /// </summary>
    /// <param name="eventId">The unique identifier of the active event to update.</param>
    /// <param name="newPriority">The new priority of the event.</param>
    void UpdatePriority(int eventId, int newPriority);

    /// <summary>
    ///     Removes the active event with the highest priority, breaking ties by the smallest event identifier.
    /// </summary>
    /// <returns>The identifier of the removed event, or -1 if there are no active events.</returns>
    int PollHighest();
}