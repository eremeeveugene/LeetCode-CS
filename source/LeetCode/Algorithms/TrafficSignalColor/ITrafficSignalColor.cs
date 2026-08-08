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

namespace LeetCode.Algorithms.TrafficSignalColor;

/// <summary>
///     https://leetcode.com/problems/traffic-signal-color/description/
/// </summary>
public interface ITrafficSignalColor
{
    /// <summary>
    ///     Determines the current state of a traffic signal given the remaining time on it.
    /// </summary>
    /// <param name="timer">The remaining time, in seconds, on the traffic signal.</param>
    /// <returns>
    ///     <c>"Green"</c> if <paramref name="timer" /> is <c>0</c>, <c>"Orange"</c> if it is <c>30</c>, <c>"Red"</c>
    ///     if it is greater than <c>30</c> and at most <c>90</c>, or <c>"Invalid"</c> otherwise.
    /// </returns>
    string TrafficSignal(int timer);
}