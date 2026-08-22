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

namespace LeetCode.Algorithms.ElevatorRequests1;

/// <summary>
///     https://leetcode.com/problems/elevator-requests-i/description/
/// </summary>
public interface IElevatorRequests1
{
    /// <summary>
    ///     Calculates the total time required for an elevator starting at floor zero to serve each requested floor in
    ///     order.
    /// </summary>
    /// <param name="n">The number of floors in the building.</param>
    /// <param name="requests">The requested floors in service order.</param>
    /// <returns>The total travel time in seconds.</returns>
    int ElevatorRequests(int n, int[] requests);
}