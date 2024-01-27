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

namespace LeetCode.Algorithms.FibonacciNumber;

/// <inheritdoc />
public class FibonacciNumberIterative : IFibonacciNumber
{
    /// <summary>
    ///     Time complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        var a = 0;
        var b = 1;

        for (var i = 2; i < n + 1; i++)
        {
            var c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}