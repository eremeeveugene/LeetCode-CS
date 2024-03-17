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

namespace LeetCode.Algorithms.InsertInterval;

/// <inheritdoc />
public class InsertIntervalIterative : IInsertInterval
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="intervals"></param>
    /// <param name="newInterval"></param>
    /// <returns></returns>
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();

        var i = 0;

        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        while (i < intervals.Length && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }

        result.Add(newInterval);

        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }

        return [.. result];
    }
}