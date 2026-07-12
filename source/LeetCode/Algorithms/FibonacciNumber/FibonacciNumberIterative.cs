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

namespace LeetCode.Algorithms.FibonacciNumber;

/// <inheritdoc />
public sealed class FibonacciNumberIterative : IFibonacciNumber
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        var a = 0;
        var b = 1;

        for (var i = 2; i <= n; i++)
        {
            var c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}