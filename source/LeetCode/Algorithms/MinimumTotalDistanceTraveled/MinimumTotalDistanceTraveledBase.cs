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
public abstract class MinimumTotalDistanceTraveledBase : IMinimumTotalDistanceTraveled
{
    protected const long Unreachable = long.MaxValue;

    /// <inheritdoc />
    public abstract long MinimumTotalDistance(IList<int> robot, int[][] factory);

    /// <summary>
    ///     Copies the robot positions into the buffer and sorts them in ascending order.
    /// </summary>
    /// <param name="robot">The positions of the robots on the X-axis.</param>
    /// <param name="robots">The buffer that receives the sorted robot positions.</param>
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    protected static void SortRobots(IList<int> robot, Span<int> robots)
    {
        var n = robot.Count;

        for (var i = 0; i < n; i++)
        {
            robots[i] = robot[i];
        }

        robots.Sort();
    }

    /// <summary>
    ///     Sorts the factories in place by position in ascending order.
    /// </summary>
    /// <param name="factory">The factories, each given as [position, limit].</param>
    /// <remarks>
    ///     Time complexity - O(m log m)
    ///     Space complexity - O(log m)
    /// </remarks>
    protected static void SortFactories(int[][] factory)
    {
        Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));
    }

    /// <summary>
    ///     Seeds the distances so that only zero repaired robots is reachable.
    /// </summary>
    /// <param name="dp">The buffer of minimum distances indexed by the number of repaired robots.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    protected static void InitializeDistances(Span<long> dp)
    {
        dp.Fill(Unreachable);

        dp[0] = 0;
    }
}