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

/// <inheritdoc />
public sealed class PrintInOrderManualResetEvent : IPrintInOrder
{
    private readonly ManualResetEvent _firstPrint = new(false);
    private readonly ManualResetEvent _secondPrint = new(false);

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _firstPrint.Set();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Second(Action printSecond)
    {
        _firstPrint.WaitOne();

        printSecond.Invoke();

        _secondPrint.Set();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Third(Action printThird)
    {
        _secondPrint.WaitOne();

        printThird.Invoke();
    }
}