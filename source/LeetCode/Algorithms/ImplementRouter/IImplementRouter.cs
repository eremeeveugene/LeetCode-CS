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

namespace LeetCode.Algorithms.ImplementRouter;

/// <summary>
///     https://leetcode.com/problems/implement-router/description/
/// </summary>
public interface IImplementRouter
{
    /// <summary>
    ///     Adds a packet to the router, evicting the oldest packet if the router is at capacity. Duplicate packets are not
    ///     added.
    /// </summary>
    /// <param name="source">The identifier of the machine that generated the packet.</param>
    /// <param name="destination">The identifier of the target machine.</param>
    /// <param name="timestamp">The time at which the packet arrived at the router.</param>
    /// <returns><c>true</c> if the packet was added; <c>false</c> if it is a duplicate.</returns>
    bool AddPacket(int source, int destination, int timestamp);

    /// <summary>
    ///     Forwards the next packet in FIFO order and removes it from the router.
    /// </summary>
    /// <returns>The forwarded packet as [source, destination, timestamp], or an empty array if the router is empty.</returns>
    int[] ForwardPacket();

    /// <summary>
    ///     Counts the packets currently stored in the router with the given <paramref name="destination" /> and a timestamp
    ///     in the inclusive range [<paramref name="startTime" />, <paramref name="endTime" />].
    /// </summary>
    /// <param name="destination">The identifier of the target machine.</param>
    /// <param name="startTime">The start of the timestamp range, inclusive.</param>
    /// <param name="endTime">The end of the timestamp range, inclusive.</param>
    /// <returns>The number of matching packets stored in the router.</returns>
    int GetCount(int destination, int startTime, int endTime);
}