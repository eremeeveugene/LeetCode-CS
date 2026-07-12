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

namespace LeetCode.Algorithms.DayOfTheYear;

/// <summary>
///     https://leetcode.com/problems/day-of-the-year/description/
/// </summary>
public interface IDayOfTheYear
{
    /// <summary>
    ///     Computes the ordinal day number of the year for the calendar date represented by <paramref name="date" />.
    /// </summary>
    /// <param name="date">The date in the "YYYY-MM-DD" format.</param>
    /// <returns>The day number of the year for the given date.</returns>
    int DayOfYear(string date);
}