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

namespace LeetCode.Algorithms.ImplementStackUsingQueues;

/// <summary>
///     https://leetcode.com/problems/implement-stack-using-queues/description/
/// </summary>
public interface IImplementStackUsingQueues
{
    /// <summary>
    ///     Pushes <paramref name="x" /> onto the top of the stack.
    /// </summary>
    /// <param name="x">The element to push.</param>
    void Push(int x);

    /// <summary>
    ///     Removes the element on the top of the stack and returns it.
    /// </summary>
    /// <returns>The element removed from the top of the stack.</returns>
    int Pop();

    /// <summary>
    ///     Returns the element on the top of the stack without removing it.
    /// </summary>
    /// <returns>The element on the top of the stack.</returns>
    int Top();

    /// <summary>
    ///     Determines whether the stack is empty.
    /// </summary>
    /// <returns><c>true</c> if the stack is empty; otherwise, <c>false</c>.</returns>
    bool Empty();
}