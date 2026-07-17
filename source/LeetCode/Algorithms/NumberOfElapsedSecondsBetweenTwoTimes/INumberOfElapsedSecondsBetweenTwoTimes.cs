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

namespace LeetCode.Algorithms.NumberOfElapsedSecondsBetweenTwoTimes;

/// <summary>
///     https://leetcode.com/problems/number-of-elapsed-seconds-between-two-times/description/
/// </summary>
public interface INumberOfElapsedSecondsBetweenTwoTimes
{
    /// <summary>
    ///     Computes the number of seconds that have elapsed from the start time to the end time, where both times are
    ///     given in the "HH:MM:SS" format and the end time is not earlier than the start time.
    /// </summary>
    /// <param name="startTime">The start time in the "HH:MM:SS" format.</param>
    /// <param name="endTime">The end time in the "HH:MM:SS" format.</param>
    /// <returns>The number of elapsed seconds between the two times.</returns>
    int SecondsBetweenTimes(string startTime, string endTime);
}