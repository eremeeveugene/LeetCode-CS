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

namespace LeetCode.Algorithms.DayOfTheWeek;

/// <summary>
///     https://leetcode.com/problems/day-of-the-week/
/// </summary>
public interface IDayOfTheWeek
{
    /// <summary>
    ///     Returns the name of the day of the week for the date given by <paramref name="day" />,
    ///     <paramref name="month" /> and <paramref name="year" />.
    /// </summary>
    /// <param name="day">The day of the month.</param>
    /// <param name="month">The month of the year.</param>
    /// <param name="year">The year.</param>
    /// <returns>The English name of the corresponding day of the week.</returns>
    string DayOfTheWeek(int day, int month, int year);
}