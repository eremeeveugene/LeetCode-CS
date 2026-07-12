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

namespace LeetCode.Algorithms.RestoreFinishingOrder;

/// <summary>
///     https://leetcode.com/problems/restore-finishing-order/description/
/// </summary>
public interface IRestoreFinishingOrder
{
    /// <summary>
    ///     Recovers the finishing order of the racers identified in <paramref name="friends" />, given the full race
    ///     finishing order of racer IDs in <paramref name="order" />.
    /// </summary>
    /// <param name="order">The IDs of every racer, listed in the order they finished the race.</param>
    /// <param name="friends">The IDs of the racers whose relative finishing order should be recovered.</param>
    /// <returns>The IDs from <paramref name="friends" /> arranged in the order they finished the race.</returns>
    int[] RecoverOrder(int[] order, int[] friends);
}