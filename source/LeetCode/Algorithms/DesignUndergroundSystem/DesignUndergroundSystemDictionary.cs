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

using System.Runtime.InteropServices;

namespace LeetCode.Algorithms.DesignUndergroundSystem;

/// <inheritdoc />
public sealed class DesignUndergroundSystemDictionary : IDesignUndergroundSystem
{
    private readonly Dictionary<int, (string StartStation, int Time)> _checkInsDictionary = new();
    private readonly Dictionary<(string StartStation, string EndStation), (int Sum, int Count)> _travelDurationsDictionary = new();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void CheckIn(int id, string stationName, int t)
    {
        _checkInsDictionary[id] = (stationName, t);
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void CheckOut(int id, string stationName, int t)
    {
        var (startStation, startTime) = _checkInsDictionary[id];

        ref var travelDuration = ref CollectionsMarshal.GetValueRefOrAddDefault(_travelDurationsDictionary, (startStation, stationName), out _);

        travelDuration.Sum += t - startTime;
        travelDuration.Count++;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public double GetAverageTime(string startStation, string endStation)
    {
        var (sum, count) = _travelDurationsDictionary[(startStation, endStation)];

        return (double)sum / count;
    }
}