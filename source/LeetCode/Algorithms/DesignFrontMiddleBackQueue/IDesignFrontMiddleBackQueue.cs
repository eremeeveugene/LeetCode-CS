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

namespace LeetCode.Algorithms.DesignFrontMiddleBackQueue;

/// <summary>
///     https://leetcode.com/problems/design-front-middle-back-queue/description/
/// </summary>
public interface IDesignFrontMiddleBackQueue
{
    /// <summary>
    ///     Inserts <paramref name="value" /> at the front of the queue.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    void PushFront(int value);

    /// <summary>
    ///     Inserts <paramref name="value" /> at the middle of the queue.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    void PushMiddle(int value);

    /// <summary>
    ///     Inserts <paramref name="value" /> at the back of the queue.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    void PushBack(int value);

    /// <summary>
    ///     Removes and returns the value at the front of the queue.
    /// </summary>
    /// <returns>The value that was at the front of the queue, or -1 if the queue was empty.</returns>
    int PopFront();

    /// <summary>
    ///     Removes and returns the value at the middle of the queue.
    /// </summary>
    /// <returns>The value that was at the middle of the queue, or -1 if the queue was empty.</returns>
    int PopMiddle();

    /// <summary>
    ///     Removes and returns the value at the back of the queue.
    /// </summary>
    /// <returns>The value that was at the back of the queue, or -1 if the queue was empty.</returns>
    int PopBack();
}