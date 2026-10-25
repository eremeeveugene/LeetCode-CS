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
public sealed class CountDaysSpentTogetherMath : ICountDaysSpentTogether
{
    private const char FirstDigit = '0';

    private static readonly int[] CumulativeDays = [0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var arriveAliceDay = ToDayOfYear(arriveAlice);
        var leaveAliceDay = ToDayOfYear(leaveAlice);
        var arriveBobDay = ToDayOfYear(arriveBob);
        var leaveBobDay = ToDayOfYear(leaveBob);

        var arrive = Math.Max(arriveAliceDay, arriveBobDay);
        var leave = Math.Min(leaveAliceDay, leaveBobDay);

        return Math.Max(0, leave - arrive + 1);
    }

    /// <summary>
    ///     Converts a date in the format "MM-DD" to its one-based day of a non-leap year.
    /// </summary>
    /// <param name="date">The date in the format "MM-DD".</param>
    /// <returns>The one-based day of the year.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int ToDayOfYear(string date)
    {
        var month = (GetDigit(date[0]) * 10) + GetDigit(date[1]);
        var day = (GetDigit(date[3]) * 10) + GetDigit(date[4]);

        return CumulativeDays[month - 1] + day;
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