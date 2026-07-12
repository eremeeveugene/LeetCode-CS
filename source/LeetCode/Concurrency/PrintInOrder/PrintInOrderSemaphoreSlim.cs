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
public sealed class PrintInOrderSemaphoreSlim : IPrintInOrder
{
    private readonly SemaphoreSlim _firstPrint = new(0, 1);
    private readonly SemaphoreSlim _secondPrint = new(0, 1);

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _firstPrint.Release();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Second(Action printSecond)
    {
        _firstPrint.Wait();

        printSecond.Invoke();

        _secondPrint.Release();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Third(Action printThird)
    {
        _secondPrint.Wait();

        printThird.Invoke();
    }
}