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
public sealed class PrintInOrderThreadSleep : IPrintInOrder
{
    private const int ThreadTimeoutMs = 10;
    private bool _isFirstPrinted;
    private bool _isSecondPrinted;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _isFirstPrinted = true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1), excluding the time spent busy-waiting on the polling loop, which depends on thread
    ///     scheduling rather than input size
    ///     Space complexity - O(1)
    /// </remarks>
    public void Second(Action printSecond)
    {
        while (!_isFirstPrinted)
        {
            Thread.Sleep(ThreadTimeoutMs);
        }

        printSecond.Invoke();

        _isSecondPrinted = true;
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1), excluding the time spent busy-waiting on the polling loop, which depends on thread
    ///     scheduling rather than input size
    ///     Space complexity - O(1)
    /// </remarks>
    public void Third(Action printThird)
    {
        while (!_isSecondPrinted)
        {
            Thread.Sleep(ThreadTimeoutMs);
        }

        printThird.Invoke();
    }
}