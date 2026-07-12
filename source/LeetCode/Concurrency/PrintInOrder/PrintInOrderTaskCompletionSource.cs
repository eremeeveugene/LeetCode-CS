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
public sealed class PrintInOrderTaskCompletionSource : IPrintInOrder
{
    private readonly TaskCompletionSource _firstPrint = new();
    private readonly TaskCompletionSource _secondPrint = new();

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _firstPrint.SetResult();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Second(Action printSecond)
    {
        _firstPrint.Task.Wait();

        printSecond.Invoke();

        _secondPrint.SetResult();
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Third(Action printThird)
    {
        _secondPrint.Task.Wait();

        printThird.Invoke();
    }
}