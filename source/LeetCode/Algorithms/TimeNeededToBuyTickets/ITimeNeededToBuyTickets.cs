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

namespace LeetCode.Algorithms.TimeNeededToBuyTickets;

/// <summary>
///     https://leetcode.com/problems/time-needed-to-buy-tickets/
/// </summary>
public interface ITimeNeededToBuyTickets
{
    /// <summary>
    ///     Simulates people standing in a circular queue, each buying one ticket per turn as described by
    ///     <paramref name="tickets" />, and computes the time at which the person at index <paramref name="k" />
    ///     finishes buying all their tickets.
    /// </summary>
    /// <param name="tickets">The array where each element is the number of tickets the corresponding person wants to buy.</param>
    /// <param name="k">The index of the person whose finish time should be computed.</param>
    /// <returns>The time taken for the person at index <paramref name="k" /> to finish buying tickets.</returns>
    int TimeRequiredToBuy(int[] tickets, int k);
}