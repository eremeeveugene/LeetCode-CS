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

namespace LeetCode.Algorithms.MinimumTimeDifference;

/// <summary>
///     https://leetcode.com/problems/minimum-time-difference/description/
/// </summary>
public interface IMinimumTimeDifference
{
    /// <summary>
    ///     Finds the minimum difference in minutes between any two times in the given list of 24-hour clock time
    ///     points, treating the times as arranged on a circular clock.
    /// </summary>
    /// <param name="timePoints">The list of time points formatted as "HH:MM".</param>
    /// <returns>The minimum difference, in minutes, between any two time points in <paramref name="timePoints" />.</returns>
    int FindMinDifference(IList<string> timePoints);
}