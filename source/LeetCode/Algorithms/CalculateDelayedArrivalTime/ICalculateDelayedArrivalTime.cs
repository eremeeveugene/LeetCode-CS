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

namespace LeetCode.Algorithms.CalculateDelayedArrivalTime;

/// <summary>
///     https://leetcode.com/problems/calculate-delayed-arrival-time/description/
/// </summary>
public interface ICalculateDelayedArrivalTime
{
    /// <summary>
    ///     Computes the arrival time of a train after a delay, on a 24-hour clock.
    /// </summary>
    /// <param name="arrivalTime">The scheduled arrival time in hours.</param>
    /// <param name="delayedTime">The delay in hours.</param>
    /// <returns>The delayed arrival time in 24-hour format.</returns>
    int FindDelayedArrivalTime(int arrivalTime, int delayedTime);
}