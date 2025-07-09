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

namespace LeetCode.Algorithms.RescheduleMeetingsForMaximumFreeTime1;

/// <inheritdoc />
public class RescheduleMeetingsForMaximumFreeTime1Greedy : IRescheduleMeetingsForMaximumFreeTime1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="eventTime"></param>
    /// <param name="k"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <returns></returns>
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        var maxFreeTime = 0;

        var n = startTime.Length;

        var currentTime = 0;

        for (var i = 0; i < n; i++)
        {
            currentTime += endTime[i] - startTime[i];

            var left = i <= k - 1 ? 0 : endTime[i - k];

            var right = i == n - 1 ? eventTime : startTime[i + 1];

            maxFreeTime = Math.Max(maxFreeTime, right - left - currentTime);

            if (i >= k - 1)
            {
                currentTime -= endTime[i - k + 1] - startTime[i - k + 1];
            }
        }

        return maxFreeTime;
    }
}