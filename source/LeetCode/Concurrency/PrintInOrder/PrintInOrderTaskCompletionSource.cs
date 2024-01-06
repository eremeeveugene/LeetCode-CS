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

/// <summary>
///     https://leetcode.com/problems/print-in-order/description/
/// </summary>
public class PrintInOrderTaskCompletionSource
{
    private readonly TaskCompletionSource _firstPrint = new();
    private readonly TaskCompletionSource _secondPrint = new();

    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _firstPrint.SetResult();
    }

    public void Second(Action printSecond)
    {
        _firstPrint.Task.Wait();

        printSecond.Invoke();

        _secondPrint.SetResult();
    }

    public void Third(Action printThird)
    {
        _secondPrint.Task.Wait();

        printThird.Invoke();
    }
}