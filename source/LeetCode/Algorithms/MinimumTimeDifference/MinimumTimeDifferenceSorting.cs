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

namespace LeetCode.Algorithms.MinimumTimeDifference;

/// <inheritdoc />
public class MinimumTimeDifferenceSorting : MinimumTimeDifferenceBase
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="timePoints"></param>
    /// <returns></returns>
    public override int FindMinDifferenceInternal(IList<string> timePoints)
    {
        var minutes = new int[timePoints.Count];

        for (var i = 0; i < minutes.Length; i++)
        {
            minutes[i] = (int)TimeSpan.Parse(timePoints[i]).TotalMinutes;
        }

        Array.Sort(minutes);

        var minDifference = DayMinutes + minutes[0] - minutes[^1];

        for (var i = 0; i < minutes.Length - 1; i++)
        {
            minDifference = Math.Min(minDifference, minutes[i + 1] - minutes[i]);
        }

        return minDifference;
    }
}