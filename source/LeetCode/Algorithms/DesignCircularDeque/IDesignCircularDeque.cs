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

namespace LeetCode.Algorithms.DesignCircularDeque;

/// <summary>
///     https://leetcode.com/problems/design-circular-deque/description/
/// </summary>
public interface IDesignCircularDeque
{
    /// <summary>
    ///     Adds <paramref name="value" /> to the front of the circular deque.
    /// </summary>
    /// <param name="value">The value to add.</param>
    /// <returns><c>true</c> if the operation is successful; otherwise, <c>false</c>.</returns>
    bool InsertFront(int value);

    /// <summary>
    ///     Adds <paramref name="value" /> to the rear of the circular deque.
    /// </summary>
    /// <param name="value">The value to add.</param>
    /// <returns><c>true</c> if the operation is successful; otherwise, <c>false</c>.</returns>
    bool InsertLast(int value);

    /// <summary>
    ///     Deletes the item at the front of the circular deque.
    /// </summary>
    /// <returns><c>true</c> if the operation is successful; otherwise, <c>false</c>.</returns>
    bool DeleteFront();

    /// <summary>
    ///     Deletes the item at the rear of the circular deque.
    /// </summary>
    /// <returns><c>true</c> if the operation is successful; otherwise, <c>false</c>.</returns>
    bool DeleteLast();

    /// <summary>
    ///     Returns the item at the front of the circular deque.
    /// </summary>
    /// <returns>The front item, or <c>-1</c> if the deque is empty.</returns>
    int GetFront();

    /// <summary>
    ///     Returns the item at the rear of the circular deque.
    /// </summary>
    /// <returns>The rear item, or <c>-1</c> if the deque is empty.</returns>
    int GetRear();

    /// <summary>
    ///     Determines whether the circular deque is empty.
    /// </summary>
    /// <returns><c>true</c> if the deque is empty; otherwise, <c>false</c>.</returns>
    bool IsEmpty();

    /// <summary>
    ///     Determines whether the circular deque is full.
    /// </summary>
    /// <returns><c>true</c> if the deque is full; otherwise, <c>false</c>.</returns>
    bool IsFull();
}