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

/// <inheritdoc />
public sealed class NumberOfElapsedSecondsBetweenTwoTimesMath : INumberOfElapsedSecondsBetweenTwoTimes
{
    private const int SecondsPerMinute = 60;
    private const int SecondsPerHour = 3600;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SecondsBetweenTimes(string startTime, string endTime)
    {
        return GetTotalSeconds(endTime) - GetTotalSeconds(startTime);
    }

    /// <summary>
    ///     Converts a time in the "HH:MM:SS" format to the total number of seconds since 00:00:00.
    /// </summary>
    /// <param name="time">The time in the "HH:MM:SS" format.</param>
    /// <returns>The total number of seconds since 00:00:00.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetTotalSeconds(string time)
    {
        var hours = ParseTwoDigitNumber(time, 0);
        var minutes = ParseTwoDigitNumber(time, 3);
        var seconds = ParseTwoDigitNumber(time, 6);

        return (hours * SecondsPerHour) + (minutes * SecondsPerMinute) + seconds;
    }

    /// <summary>
    ///     Parses a two-digit number from the time string starting at the specified index.
    /// </summary>
    /// <param name="time">The time in the "HH:MM:SS" format.</param>
    /// <param name="startIndex">The index of the first digit.</param>
    /// <returns>The parsed two-digit number.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int ParseTwoDigitNumber(string time, int startIndex)
    {
        return ((time[startIndex] - '0') * 10) + time[startIndex + 1] - '0';
    }
}