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

namespace LeetCode.Algorithms.CountDaysSpentTogether;

/// <inheritdoc />
public sealed class CountDaysSpentTogetherSimulation : ICountDaysSpentTogether
{
    private const int MonthsCount = 12;
    private const char FirstDigit = '0';

    private static readonly int[] DaysInMonths = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(d)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var arriveAliceDateKey = ToDateKey(arriveAlice);
        var leaveAliceDateKey = ToDateKey(leaveAlice);
        var arriveBobDateKey = ToDateKey(arriveBob);
        var leaveBobDateKey = ToDateKey(leaveBob);

        var arrive = Math.Max(arriveAliceDateKey, arriveBobDateKey);
        var leave = Math.Min(leaveAliceDateKey, leaveBobDateKey);

        var daysTogether = 0;

        for (var month = 1; month <= MonthsCount; month++)
        {
            var daysInMonth = DaysInMonths[month - 1];

            for (var day = 1; day <= daysInMonth; day++)
            {
                var dateKey = (month * 100) + day;

                if (dateKey < arrive || dateKey > leave)
                {
                    continue;
                }

                daysTogether++;
            }
        }

        return daysTogether;
    }

    /// <summary>
    ///     Converts a date in the format "MM-DD" to a comparable key equal to month * 100 + day.
    /// </summary>
    /// <param name="date">The date in the format "MM-DD".</param>
    /// <returns>The date key that preserves chronological order.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int ToDateKey(string date)
    {
        var month = (GetDigit(date[0]) * 10) + GetDigit(date[1]);
        var day = (GetDigit(date[3]) * 10) + GetDigit(date[4]);

        return (month * 100) + day;
    }

    /// <summary>
    ///     Converts a digit character to its numeric value.
    /// </summary>
    /// <param name="c">The digit character.</param>
    /// <returns>The numeric value of the digit.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetDigit(char c)
    {
        return c - FirstDigit;
    }
}