// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DayOfTheYear;

/// <inheritdoc />
public class DayOfTheYearMath : IDayOfTheYear
{
    private static readonly int[] CumulativeDays = [0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334];

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public int DayOfYear(string date)
    {
        var dateSpan = date.AsSpan();

        var year = int.Parse(dateSpan[..4]);
        var month = int.Parse(dateSpan.Slice(5, 2));
        var day = int.Parse(dateSpan.Slice(8, 2));

        var dayOfYear = CumulativeDays[month - 1] + day;

        if (month > 2 && DateTime.IsLeapYear(year))
        {
            dayOfYear++;
        }

        return dayOfYear;
    }
}