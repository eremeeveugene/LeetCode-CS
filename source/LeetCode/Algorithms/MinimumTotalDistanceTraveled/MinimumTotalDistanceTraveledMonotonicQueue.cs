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
public sealed class MinimumTotalDistanceTraveledMonotonicQueue : MinimumTotalDistanceTraveledBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n + m log m + n * m)
    ///     Space complexity - O(n + log m)
    /// </remarks>
    public override long MinimumTotalDistance(IList<int> robot, int[][] factory)
    {
        var n = robot.Count;
        var m = factory.Length;

        Span<int> robots = stackalloc int[n];
        Span<long> dp = stackalloc long[n + 1];
        Span<long> nextDp = stackalloc long[n + 1];
        Span<long> prefixDistances = stackalloc long[n + 1];
        Span<int> queue = stackalloc int[n + 1];

        SortRobots(robot, robots);
        SortFactories(factory);
        InitializeDistances(dp);

        for (var j = 0; j < m; j++)
        {
            var position = factory[j][0];
            var limit = factory[j][1];

            ComputePrefixDistances(robots, position, prefixDistances);
            ComputeNextDistances(dp, prefixDistances, limit, queue, nextDp);

            var temporaryDp = dp;

            dp = nextDp;
            nextDp = temporaryDp;
        }

        return dp[n];
    }

    /// <summary>
    ///     Computes the prefix sums of the distances from each sorted robot to the factory.
    /// </summary>
    /// <param name="robots">The robot positions sorted in ascending order.</param>
    /// <param name="position">The position of the factory.</param>
    /// <param name="prefixDistances">The buffer that receives the prefix sums, starting with zero.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void ComputePrefixDistances(ReadOnlySpan<int> robots, int position, Span<long> prefixDistances)
    {
        var n = robots.Length;

        for (var i = 0; i < n; i++)
        {
            var robotPosition = robots[i];
            var distanceToFactory = Math.Abs((long)robotPosition - position);

            prefixDistances[i + 1] = prefixDistances[i] + distanceToFactory;
        }
    }

    /// <summary>
    ///     Computes the minimum distances after the factory repairs at most <paramref name="limit" /> consecutive
    ///     robots, using a sliding window minimum over the candidates.
    /// </summary>
    /// <param name="dp">The minimum distances before the factory, indexed by the number of repaired robots.</param>
    /// <param name="prefixDistances">The prefix sums of the distances from each sorted robot to the factory.</param>
    /// <param name="limit">The maximum number of robots the factory can repair.</param>
    /// <param name="queue">The buffer for the monotonic queue of indexes.</param>
    /// <param name="nextDp">The buffer that receives the minimum distances after the factory.</param>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void ComputeNextDistances(
        ReadOnlySpan<long> dp,
        ReadOnlySpan<long> prefixDistances,
        int limit,
        Span<int> queue,
        Span<long> nextDp)
    {
        var n = dp.Length - 1;

        var queueHead = 0;
        var queueTail = 0;

        for (var i = 0; i <= n; i++)
        {
            var distance = dp[i];

            if (distance != Unreachable)
            {
                queueTail = PushCandidate(dp, prefixDistances, queue, queueHead, queueTail, i);
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
            var bestCandidate = GetCandidate(dp, prefixDistances, bestIndex);

            nextDp[i] = prefixDistances[i] + bestCandidate;
        }
    }

    /// <summary>
    ///     Pushes the index onto the monotonic queue, removing every queued index whose candidate is not smaller.
    /// </summary>
    /// <param name="dp">The minimum distances before the factory, indexed by the number of repaired robots.</param>
    /// <param name="prefixDistances">The prefix sums of the distances from each sorted robot to the factory.</param>
    /// <param name="queue">The buffer for the monotonic queue of indexes.</param>
    /// <param name="queueHead">The index of the first element in the queue.</param>
    /// <param name="queueTail">The index one past the last element in the queue.</param>
    /// <param name="index">The index to push.</param>
    /// <returns>The new tail of the queue.</returns>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int PushCandidate(
        ReadOnlySpan<long> dp,
        ReadOnlySpan<long> prefixDistances,
        Span<int> queue,
        int queueHead,
        int queueTail,
        int index)
    {
        var candidate = GetCandidate(dp, prefixDistances, index);

        while (queueTail > queueHead)
        {
            var lastIndex = queue[queueTail - 1];
            var lastCandidate = GetCandidate(dp, prefixDistances, lastIndex);

            if (lastCandidate < candidate)
            {
                break;
            }

            queueTail--;
        }

        queue[queueTail] = index;

        queueTail++;

        return queueTail;
    }

    /// <summary>
    ///     Computes the candidate value of an index, which is its minimum distance minus its prefix distance.
    /// </summary>
    /// <param name="dp">The minimum distances before the factory, indexed by the number of repaired robots.</param>
    /// <param name="prefixDistances">The prefix sums of the distances from each sorted robot to the factory.</param>
    /// <param name="index">The index to evaluate.</param>
    /// <returns>The candidate value of the index.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static long GetCandidate(ReadOnlySpan<long> dp, ReadOnlySpan<long> prefixDistances, int index)
    {
        return dp[index] - prefixDistances[index];
    }
}