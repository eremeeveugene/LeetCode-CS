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

namespace LeetCode.Algorithms.DesignCircularQueue;

/// <summary>
///     https://leetcode.com/problems/design-circular-queue/description/
/// </summary>
public interface IDesignCircularQueue
{
    /// <summary>
    ///     Inserts <paramref name="value" /> into the circular queue.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    /// <returns><c>true</c> if the operation is successful; otherwise, <c>false</c>.</returns>
    bool EnQueue(int value);

    /// <summary>
    ///     Deletes the item at the front of the circular queue.
    /// </summary>
    /// <returns><c>true</c> if the operation is successful; otherwise, <c>false</c>.</returns>
    bool DeQueue();

    /// <summary>
    ///     Returns the item at the front of the circular queue.
    /// </summary>
    /// <returns>The front item, or <c>-1</c> if the queue is empty.</returns>
    int Front();

    /// <summary>
    ///     Returns the item at the rear of the circular queue.
    /// </summary>
    /// <returns>The rear item, or <c>-1</c> if the queue is empty.</returns>
    int Rear();

    /// <summary>
    ///     Determines whether the circular queue is empty.
    /// </summary>
    /// <returns><c>true</c> if the queue is empty; otherwise, <c>false</c>.</returns>
    bool IsEmpty();

    /// <summary>
    ///     Determines whether the circular queue is full.
    /// </summary>
    /// <returns><c>true</c> if the queue is full; otherwise, <c>false</c>.</returns>
    bool IsFull();
}