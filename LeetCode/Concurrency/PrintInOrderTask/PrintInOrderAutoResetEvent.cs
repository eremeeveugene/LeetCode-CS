﻿namespace LeetCode.Concurrency.PrintInOrderTask;

public class PrintInOrderAutoResetEvent
{
    private static readonly AutoResetEvent FirstPrint = new(false);
    private static readonly AutoResetEvent SecondPrint = new(false);

    public void First(Action printFirst)
    {
        printFirst();

        FirstPrint.Set();
    }

    public void Second(Action printSecond)
    {
        FirstPrint.WaitOne();

        printSecond();

        SecondPrint.Set();
    }

    public void Third(Action printThird)
    {
        SecondPrint.WaitOne();

        printThird();
    }
}
