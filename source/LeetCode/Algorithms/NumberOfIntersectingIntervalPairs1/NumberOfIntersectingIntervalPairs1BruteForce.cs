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

namespace LeetCode.Algorithms.NumberOfIntersectingIntervalPairs1;

/// <inheritdoc />
public sealed class NumberOfIntersectingIntervalPairs1BruteForce : INumberOfIntersectingIntervalPairs1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountIntersectingPairs(int[][] intervals)
    {
        var n = intervals.Length;

        var count = 0;

        for (var i = 0; i < n - 1; i++)
        {
            var firstInterval = intervals[i];
            var firstIntervalStart = firstInterval[0];
            var firstIntervalEnd = firstInterval[1];

            for (var j = i + 1; j < n; j++)
            {
                var secondInterval = intervals[j];
                var secondIntervalStart = secondInterval[0];
                var secondIntervalEnd = secondInterval[1];

                if (firstIntervalEnd < secondIntervalStart || firstIntervalStart > secondIntervalEnd)
                {
                    continue;
                }

                count++;
            }
        }

        return count;
    }
}