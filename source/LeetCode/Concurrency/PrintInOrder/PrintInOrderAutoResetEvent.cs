// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Concurrency.PrintInOrder;

public class PrintInOrderAutoResetEvent
{
    private readonly AutoResetEvent _firstPrint  = new(false);
    private readonly AutoResetEvent _secondPrint = new(false);

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