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

namespace LeetCode.Algorithms.DayOfTheWeek;

/// <inheritdoc />
public class DayOfTheWeekMath : IDayOfTheWeek
{
    private readonly Dictionary<int, string> _weekDays = new()
    {
        { 0, "Monday" },
        { 1, "Tuesday" },
        { 2, "Wednesday" },
        { 3, "Thursday" },
        { 4, "Friday" },
        { 5, "Saturday" },
        { 6, "Sunday" }
    };

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="day"></param>
    /// <param name="month"></param>
    /// <param name="year"></param>
    /// <returns></returns>
    public string DayOfTheWeek(int day, int month, int year)
    {
        if (month < 3)
        {
            month += 12;
            year -= 1;
        }

        var k = year % 100;
        var j = year / 100;

        var h = (day + (13 * (month + 1) / 5) + k + (k / 4) + (j / 4) + (5 * j)) % 7;

        var dayOfWeek = (h + 5) % 7;

        return _weekDays[dayOfWeek];
    }
}