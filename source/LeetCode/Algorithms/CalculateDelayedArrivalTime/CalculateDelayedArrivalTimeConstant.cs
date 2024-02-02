// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CalculateDelayedArrivalTime;

/// <inheritdoc />
public class CalculateDelayedArrivalTimeConstant : ICalculateDelayedArrivalTime
{
    /// <summary>
    ///     Time complexity - O(1)
    /// </summary>
    /// <param name="arrivalTime"></param>
    /// <param name="delayedTime"></param>
    /// <returns></returns>
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
    {
        return (arrivalTime + delayedTime) % 24;
    }
}