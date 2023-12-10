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

public class PrintInOrderThreadSleep
{
    private const int  ThreadTimeoutMs = 10;
    private       bool _isFirstPrinted;
    private       bool _isSecondPrinted;

    public void First(Action printFirst)
    {
        printFirst.Invoke();

        _isFirstPrinted = true;
    }

    public void Second(Action printSecond)
    {
        while (!_isFirstPrinted) Thread.Sleep(ThreadTimeoutMs);

        printSecond.Invoke();

        _isSecondPrinted = true;
    }

    public void Third(Action printThird)
    {
        while (!_isSecondPrinted) Thread.Sleep(ThreadTimeoutMs);

        printThird.Invoke();
    }
}