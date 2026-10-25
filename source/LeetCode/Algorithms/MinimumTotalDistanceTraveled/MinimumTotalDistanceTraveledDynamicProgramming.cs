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
public sealed class MinimumTotalDistanceTraveledDynamicProgramming : IMinimumTotalDistanceTraveled
{
    private const long Unreachable = long.MaxValue;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m log m + n * s)
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

        dp.Fill(Unreachable);

        dp[0] = 0;

        for (var j = 0; j < m; j++)
        {
            var position = factory[j][0];
            var limit = factory[j][1];

            for (var slot = 0; slot < limit; slot++)
            {
                for (var i = n; i >= 1; i--)
                {
                    var previousDistance = dp[i - 1];

                    if (previousDistance == Unreachable)
                    {
                        continue;
                    }

                    var robotPosition = robots[i - 1];
                    var distanceToFactory = Math.Abs((long)robotPosition - position);

                    dp[i] = Math.Min(dp[i], previousDistance + distanceToFactory);
                }
            }
        }

        return dp[n];
    }
}