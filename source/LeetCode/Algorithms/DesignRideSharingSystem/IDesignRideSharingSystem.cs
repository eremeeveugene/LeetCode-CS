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

namespace LeetCode.Algorithms.DesignRideSharingSystem;

/// <summary>
///     https://leetcode.com/problems/design-ride-sharing-system/description/
/// </summary>
public interface IDesignRideSharingSystem
{
    /// <summary>
    ///     Adds a rider to the end of the waiting queue.
    /// </summary>
    /// <param name="riderId">The unique rider identifier.</param>
    void AddRider(int riderId);

    /// <summary>
    ///     Adds a driver to the end of the available queue.
    /// </summary>
    /// <param name="driverId">The unique driver identifier.</param>
    void AddDriver(int driverId);

    /// <summary>
    ///     Matches and removes the earliest available driver and earliest waiting rider.
    /// </summary>
    /// <returns>The driver and rider identifiers, in that order, or [-1, -1] if no match is available.</returns>
    int[] MatchDriverWithRider();

    /// <summary>
    ///     Cancels the rider's request if the rider is waiting and has not been matched.
    /// </summary>
    /// <param name="riderId">The rider identifier to cancel.</param>
    void CancelRider(int riderId);
}
