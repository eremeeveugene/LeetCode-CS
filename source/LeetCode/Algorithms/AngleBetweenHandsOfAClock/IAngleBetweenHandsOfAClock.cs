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

/// <summary>
///     https://leetcode.com/problems/angle-between-hands-of-a-clock/description
/// </summary>
public interface IAngleBetweenHandsOfAClock
{
    /// <summary>
    ///     Given the time as <paramref name="hour" /> and <paramref name="minutes" />, returns the smaller angle (in
    ///     degrees) formed between the hour hand and the minute hand of a clock. The minute hand sweeps <c>6</c> degrees per
    ///     minute, while the hour hand sweeps <c>30</c> degrees per hour plus <c>0.5</c> degrees per minute.
    /// </summary>
    /// <param name="hour">The hour component of the time, where <c>1 &lt;= hour &lt;= 12</c>.</param>
    /// <param name="minutes">The minute component of the time, where <c>0 &lt;= minutes &lt;= 59</c>.</param>
    /// <returns>The smaller angle between the two hands, in degrees, within <c>10^-5</c> of the actual value.</returns>
    double AngleClock(int hour, int minutes);
}