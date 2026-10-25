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

namespace LeetCode.Algorithms.MinimumTotalDistanceTraveled;

/// <inheritdoc />
public sealed class MinimumTotalDistanceTraveledMonotonicQueue : IMinimumTotalDistanceTraveled
{
    private const long Unreachable = long.MaxValue;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n + m log m + n * m)
    ///     Space complexity - O(n + log m)
    /// </remarks>
    public long MinimumTotalDistance(IList<int> robot, int[][] factory)
    {
        var n = robot.Count;
        var m = factory.Length;

        Span<int> robots = stackalloc int[n];

        for (var i = 0; i < n; i++)
        {
            robots[i] = robot[i];
        }

        robots.Sort();

        Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));

        Span<long> dp = stackalloc long[n + 1];
        Span<long> nextDp = stackalloc long[n + 1];
        Span<long> prefixDistances = stackalloc long[n + 1];
        Span<int> queue = stackalloc int[n + 1];

        dp.Fill(Unreachable);

        dp[0] = 0;

        for (var j = 0; j < m; j++)
        {
            var position = factory[j][0];
            var limit = factory[j][1];

            for (var i = 0; i < n; i++)
            {
                var robotPosition = robots[i];
                var distanceToFactory = Math.Abs((long)robotPosition - position);

                prefixDistances[i + 1] = prefixDistances[i] + distanceToFactory;
            }

            var queueHead = 0;
            var queueTail = 0;

            for (var i = 0; i <= n; i++)
            {
                var distance = dp[i];

                if (distance != Unreachable)
                {
                    var candidate = distance - prefixDistances[i];

                    while (queueTail > queueHead)
                    {
                        var lastIndex = queue[queueTail - 1];
                        var lastCandidate = dp[lastIndex] - prefixDistances[lastIndex];

                        if (lastCandidate < candidate)
                        {
                            break;
                        }

                        queueTail--;
                    }

                    queue[queueTail] = i;

                    queueTail++;
                }

                while (queueTail > queueHead && queue[queueHead] < i - limit)
                {
                    queueHead++;
                }

                if (queueTail == queueHead)
                {
                    nextDp[i] = Unreachable;

                    continue;
                }

                var bestIndex = queue[queueHead];
                var bestCandidate = dp[bestIndex] - prefixDistances[bestIndex];

                nextDp[i] = prefixDistances[i] + bestCandidate;
            }

            var temporaryDp = dp;

            dp = nextDp;
            nextDp = temporaryDp;
        }

        return dp[n];
    }
}