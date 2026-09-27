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
///     Uses fixed-size array queues and direct rider-state indexing within the problem's limits.
///     Space complexity - O(1) under the fixed ID and operation limits
/// </remarks>
public sealed class DesignRideSharingSystemFixedArrays : IDesignRideSharingSystem
{
    private const int MaximumId = 1000;
    private const int MaximumOperations = 1000;
    private static readonly int[] NoMatch = [-1, -1];
    private readonly int[] _drivers = new int[MaximumOperations];
    private readonly bool[] _isRiderWaiting = new bool[MaximumId + 1];
    private readonly int[] _riders = new int[MaximumOperations];
    private int _driverHead;
    private int _driverTail;
    private int _riderHead;
    private int _riderTail;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void AddRider(int riderId)
    {
        _riders[_riderTail++] = riderId;

        _isRiderWaiting[riderId] = true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void AddDriver(int driverId)
    {
        _drivers[_driverTail++] = driverId;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Each queued rider is examined at most once, including canceled riders.
    ///     Time complexity - O(1) amortized
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] MatchDriverWithRider()
    {
        if (_driverHead == _driverTail)
        {
            return NoMatch;
        }

        while (_riderHead < _riderTail)
        {
            var riderId = _riders[_riderHead++];

            if (!_isRiderWaiting[riderId])
            {
                continue;
            }

            _isRiderWaiting[riderId] = false;

            var driverId = _drivers[_driverHead++];

            return [driverId, riderId];
        }

        return NoMatch;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void CancelRider(int riderId)
    {
        _isRiderWaiting[riderId] = false;
    }
}