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
    private const double FullCircle = 360.0;

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="hour"></param>
    /// <param name="minutes"></param>
    /// <returns></returns>
    public double AngleClock(int hour, int minutes)
    {
        var minuteFraction = minutes / 60.0;

        var minuteAngle = minuteFraction * FullCircle;
        var hourAngle = (hour + minuteFraction) / 12.0 * FullCircle;

        var difference = double.Abs(hourAngle - minuteAngle);

        return double.Min(difference, FullCircle - difference);
    }
}