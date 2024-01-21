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

namespace LeetCode.Concurrency.FizzBuzzMultithreaded;

/// <inheritdoc />
public class FizzBuzzMultithreadedMonitorLock(int length) : IFizzBuzzMultithreaded
{
    private readonly object _lock = new();
    private int _number = 1;

    public void Fizz(Action printFizz)
    {
        lock (_lock)
        {
            while (_number <= length)
            {
                while (_number <= length && (_number % 3 != 0 || _number % 5 == 0))
                {
                    Monitor.Wait(_lock);

                    if (_number > length)
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
            while (_number <= length)
            {
                while (_number % 3 == 0 || _number % 5 != 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > length)
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
            while (_number <= length)
            {
                while (_number % 3 != 0 || _number % 5 != 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > length)
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
            while (_number <= length)
            {
                while (_number % 3 == 0 || _number % 5 == 0)
                {
                    Monitor.Wait(_lock);

                    if (_number > length)
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