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

namespace LeetCode.Algorithms.DesignStackWithIncrementOperation;

/// <summary>
///     https://leetcode.com/problems/design-a-stack-with-increment-operation/
/// </summary>
public interface IDesignStackWithIncrementOperation
{
    /// <summary>
    ///     Pushes <paramref name="x" /> onto the top of the stack if the stack has not reached its maximum size.
    /// </summary>
    /// <param name="x">The value to push onto the stack.</param>
    void Push(int x);

    /// <summary>
    ///     Removes and returns the value on the top of the stack.
    /// </summary>
    /// <returns>The value on the top of the stack, or -1 if the stack is empty.</returns>
    int Pop();

    /// <summary>
    ///     Increments the bottom <paramref name="k" /> elements of the stack by <paramref name="val" />. If there are fewer
    ///     than <paramref name="k" /> elements, increments all elements.
    /// </summary>
    /// <param name="k">The number of bottom elements to increment.</param>
    /// <param name="val">The value to add to each of the affected elements.</param>
    void Increment(int k, int val);
}