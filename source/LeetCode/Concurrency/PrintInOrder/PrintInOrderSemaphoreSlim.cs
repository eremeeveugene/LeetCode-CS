﻿// --------------------------------------------------------------------------------
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
public class PrintInOrderSemaphoreSlim : IPrintInOrder
{
    private readonly SemaphoreSlim _firstPrint = new(0, 1);
    private readonly SemaphoreSlim _secondPrint = new(0, 1);

    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _firstPrint.Release();
    }

    public void Second(Action printSecond)
    {
        _firstPrint.Wait();

        printSecond.Invoke();

        _secondPrint.Release();
    }

    public void Third(Action printThird)
    {
        _secondPrint.Wait();

        printThird.Invoke();
    }
}