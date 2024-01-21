// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class PrintInOrderManualResetEvent : IPrintInOrder
{
    private readonly ManualResetEvent _firstPrint = new(false);
    private readonly ManualResetEvent _secondPrint = new(false);

    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _firstPrint.Set();
    }

    public void Second(Action printSecond)
    {
        _firstPrint.WaitOne();

        printSecond.Invoke();

        _secondPrint.Set();
    }

    public void Third(Action printThird)
    {
        _secondPrint.WaitOne();

        printThird.Invoke();
    }
}