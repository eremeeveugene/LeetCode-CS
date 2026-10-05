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

namespace LeetCode.Algorithms.SetIntersectionSizeAtLeastTwo;

/// <inheritdoc />
public sealed class SetIntersectionSizeAtLeastTwoGreedy : ISetIntersectionSizeAtLeastTwo
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * log(n))
    ///     Space complexity - O(log(n))
    /// </remarks>
    public int IntersectionSizeTwo(int[][] intervals)
    {
        var n = intervals.Length;

        Array.Sort(intervals, (a, b) => a[1] != b[1] ? a[1].CompareTo(b[1]) : b[0].CompareTo(a[0]));

        var result = 0;

        var secondLast = -1;
        var last = -1;

        for (var i = 0; i < n; i++)
        {
            var interval = intervals[i];
            var start = interval[0];
            var end = interval[1];

            if (start <= secondLast)
            {
                continue;
            }

            if (start <= last)
            {
                result++;

                secondLast = last;
            }
            else
            {
                result += 2;

                secondLast = end - 1;
            }

            last = end;
        }

        return result;
    }
}