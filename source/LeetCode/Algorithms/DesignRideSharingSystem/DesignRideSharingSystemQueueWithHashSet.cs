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

namespace LeetCode.Algorithms.DesignRideSharingSystem;

/// <inheritdoc />
/// <remarks>
///     Keeps riders and drivers in arrival order and skips canceled riders when matching.
///     Space complexity - O(n), where n is the number of operations
/// </remarks>
public sealed class DesignRideSharingSystemQueueWithHashSet : IDesignRideSharingSystem
{
    private static readonly int[] NoMatch = [-1, -1];
    private readonly HashSet<int> _cancelledRidersHashSet = [];
    private readonly Queue<int> _driversQueue = [];
    private readonly Queue<int> _ridersQueue = [];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1) amortized
    /// </remarks>
    public void AddRider(int riderId)
    {
        _cancelledRidersHashSet.Remove(riderId);

        _ridersQueue.Enqueue(riderId);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1) amortized
    /// </remarks>
    public void AddDriver(int driverId)
    {
        _driversQueue.Enqueue(driverId);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Each queued rider is removed at most once, including canceled riders.
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] MatchDriverWithRider()
    {
        if (_driversQueue.Count == 0)
        {
            return NoMatch;
        }

        while (_ridersQueue.TryDequeue(out var riderId))
        {
            if (_cancelledRidersHashSet.Remove(riderId))
            {
                continue;
            }

            var driverId = _driversQueue.Dequeue();

            return [driverId, riderId];
        }

        return NoMatch;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1) amortized
    /// </remarks>
    public void CancelRider(int riderId)
    {
        _cancelledRidersHashSet.Add(riderId);
    }
}