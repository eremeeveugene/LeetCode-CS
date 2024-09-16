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
public class MinimumTimeDifferenceBucketSort : MinimumTimeDifferenceBase
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="timePoints"></param>
    /// <returns></returns>
    public override int FindMinDifferenceInternal(IList<string> timePoints)
    {
        var minutes = new bool[DayMinutes];

        foreach (var timePoint in timePoints)
        {
            var totalMinutes = (int)TimeSpan.Parse(timePoint).TotalMinutes;

            if (minutes[totalMinutes])
            {
                return 0;
            }

            minutes[totalMinutes] = true;
        }

        var minDifference = int.MaxValue;
        var first = -1;
        var last = -1;
        var previous = -1;

        for (var i = 0; i < DayMinutes; i++)
        {
            if (!minutes[i])
            {
                continue;
            }

            if (first == -1)
            {
                first = i;
            }

            if (previous != -1)
            {
                minDifference = Math.Min(minDifference, i - previous);
            }

            previous = i;
            last = i;
        }

        return Math.Min(minDifference, DayMinutes + first - last);
    }
}