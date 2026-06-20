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

namespace LeetCode.Algorithms.AngleBetweenHandsOfAClock;

/// <inheritdoc />
public sealed class AngleBetweenHandsOfAClockMath : IAngleBetweenHandsOfAClock
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="hour"></param>
    /// <param name="minutes"></param>
    /// <returns></returns>
    public double AngleClock(int hour, int minutes)
    {
        hour %= 12;

        var minuteAngle = 6.0 * minutes;
        var hourAngle = (30.0 * hour) + (0.5 * minutes);

        var difference = double.Abs(hourAngle - minuteAngle);

        return double.Min(difference, 360.0 - difference);
    }
}