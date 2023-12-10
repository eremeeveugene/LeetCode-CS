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

/// <summary>
///     https://leetcode.com/problems/print-in-order/description/
/// </summary>
public class PrintInOrderMonitor
{
    private readonly object _lock = new();
    private int _step = 1;

    public void First(Action printFirst)
    {
        lock (_lock)
        {
            printFirst.Invoke();

            _step = 2;

            Monitor.PulseAll(_lock);
        }
    }

    public void Second(Action printSecond)
    {
        lock (_lock)
        {
            while (_step != 2)
            {
                Monitor.Wait(_lock);
            }

            printSecond.Invoke();

            _step = 3;

            Monitor.PulseAll(_lock);
        }
    }

    public void Third(Action printThird)
    {
        lock (_lock)
        {
            while (_step != 3)
            {
                Monitor.Wait(_lock);
            }

            printThird.Invoke();
        }
    }
}