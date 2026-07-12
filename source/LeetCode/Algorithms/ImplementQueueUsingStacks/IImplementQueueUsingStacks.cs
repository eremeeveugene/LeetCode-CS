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

namespace LeetCode.Algorithms.ImplementQueueUsingStacks;

/// <summary>
///     https://leetcode.com/problems/implement-queue-using-stacks/description/
/// </summary>
public interface IImplementQueueUsingStacks
{
    /// <summary>
    ///     Pushes <paramref name="x" /> to the back of the queue.
    /// </summary>
    /// <param name="x">The element to push.</param>
    void Push(int x);

    /// <summary>
    ///     Removes the element from the front of the queue and returns it.
    /// </summary>
    /// <returns>The element removed from the front of the queue.</returns>
    int Pop();

    /// <summary>
    ///     Returns the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The element at the front of the queue.</returns>
    int Peek();

    /// <summary>
    ///     Determines whether the queue is empty.
    /// </summary>
    /// <returns><c>true</c> if the queue is empty; otherwise, <c>false</c>.</returns>
    bool Empty();
}