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

namespace LeetCode.Algorithms.DesignUndergroundSystem;

/// <summary>
///     https://leetcode.com/problems/design-underground-system/description/
/// </summary>
public interface IDesignUndergroundSystem
{
    /// <summary>
    ///     Records that the customer with card id <paramref name="id" /> checks in at station
    ///     <paramref name="stationName" /> at time <paramref name="t" />. A customer can only be checked into one place at a
    ///     time.
    /// </summary>
    /// <param name="id">The card id of the customer checking in.</param>
    /// <param name="stationName">The name of the station the customer checks in at.</param>
    /// <param name="t">The time of the check in.</param>
    void CheckIn(int id, string stationName, int t);

    /// <summary>
    ///     Records that the customer with card id <paramref name="id" /> checks out from station
    ///     <paramref name="stationName" /> at time <paramref name="t" />, completing a trip that began with the matching check
    ///     in.
    /// </summary>
    /// <param name="id">The card id of the customer checking out.</param>
    /// <param name="stationName">The name of the station the customer checks out from.</param>
    /// <param name="t">The time of the check out. It is guaranteed to be greater than the matching check in time.</param>
    void CheckOut(int id, string stationName, int t);

    /// <summary>
    ///     Returns the average time it takes to travel directly from <paramref name="startStation" /> to
    ///     <paramref name="endStation" />, computed over all previous trips that checked in at <paramref name="startStation" />
    ///     and checked out at <paramref name="endStation" />. At least one such trip is guaranteed to have happened before this
    ///     call.
    /// </summary>
    /// <param name="startStation">The station the trip starts from.</param>
    /// <param name="endStation">The station the trip ends at.</param>
    /// <returns>The average travel time from <paramref name="startStation" /> to <paramref name="endStation" />.</returns>
    double GetAverageTime(string startStation, string endStation);
}