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

namespace LeetCode.Concurrency.FizzBuzzMultithreaded;

/// <inheritdoc />
public sealed class FizzBuzzMultithreadedMonitorLock : IFizzBuzzMultithreaded
{
    private readonly object _lock = new();
    private readonly int _n;
    private int _number = 1;

    public FizzBuzzMultithreadedMonitorLock(int n)
    {
        _n = n;
    }

    public void Fizz(Action printFizz)
    {
        lock (_lock)
        {
            while (_number <= _n)
            {
                while (_number <= _n && (_number % 3 != 0 || _number % 5 == 0))
                {
                    Monitor.Wait(_lock);

                    if (_number > _n)
                    {
                        return;
                    }
                }

                printFizz.Invoke();

                IncrementNumber();
            }
        }
    }

    public void Buzz(Action printBuzz)
    {
        lock (_lock)
        {
            while (_number <= _n)
            {
                while (_number % 3 == 0 || _number % 5 != 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > _n)
                    {
                        return;
                    }
                }

                printBuzz.Invoke();

                IncrementNumber();
            }
        }
    }

    public void Fizzbuzz(Action printFizzBuzz)
    {
        lock (_lock)
        {
            while (_number <= _n)
            {
                while (_number % 3 != 0 || _number % 5 != 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > _n)
                    {
                        return;
                    }
                }

                printFizzBuzz.Invoke();

                IncrementNumber();
            }
        }
    }

    public void Number(Action<int> printNumber)
    {
        lock (_lock)
        {
            while (_number <= _n)
            {
                while (_number % 3 == 0 || _number % 5 == 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > _n)
                    {
                        return;
                    }
                }

                printNumber.Invoke(_number);

                IncrementNumber();
            }
        }
    }

    private void IncrementNumber()
    {
        _number++;

        Monitor.PulseAll(_lock);
    }
}