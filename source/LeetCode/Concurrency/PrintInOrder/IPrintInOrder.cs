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

namespace LeetCode.Concurrency.PrintInOrder;

/// <summary>
///     https://leetcode.com/problems/print-in-order/description/
/// </summary>
public interface IPrintInOrder
{
    /// <summary>
    ///     Invokes <paramref name="printFirst" /> and ensures it completes before <see cref="Second" /> is allowed
    ///     to run.
    /// </summary>
    /// <param name="printFirst">The callback that prints "first".</param>
    void First(Action printFirst);

    /// <summary>
    ///     Invokes <paramref name="printFirst" /> after <see cref="First" /> has completed, and ensures it
    ///     completes before <see cref="Third" /> is allowed to run.
    /// </summary>
    /// <param name="printFirst">The callback that prints "second".</param>
    void Second(Action printFirst);

    /// <summary>
    ///     Invokes <paramref name="printFirst" /> after both <see cref="First" /> and <see cref="Second" /> have
    ///     completed.
    /// </summary>
    /// <param name="printFirst">The callback that prints "third".</param>
    void Third(Action printFirst);
}