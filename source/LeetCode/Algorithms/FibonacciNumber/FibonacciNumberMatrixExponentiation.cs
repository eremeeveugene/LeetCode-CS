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
public class FibonacciNumberMatrixExponentiation : IFibonacciNumber
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int[,] f = { { 1, 1 }, { 1, 0 } };

        Power(f, n - 1);

        return f[0, 0];
    }

    private static void Power(int[,] f, int n)
    {
        if (n <= 1)
        {
            return;
        }

        int[,] m = { { 1, 1 }, { 1, 0 } };

        Power(f, n / 2);
        Multiply(f, f);

        if (n % 2 != 0)
        {
            Multiply(f, m);
        }
    }

    private static void Multiply(int[,] a, int[,] b)
    {
        var x = (a[0, 0] * b[0, 0]) + (a[0, 1] * b[1, 0]);
        var y = (a[0, 0] * b[0, 1]) + (a[0, 1] * b[1, 1]);
        var z = (a[1, 0] * b[0, 0]) + (a[1, 1] * b[1, 0]);
        var w = (a[1, 0] * b[0, 1]) + (a[1, 1] * b[1, 1]);

        a[0, 0] = x;
        a[0, 1] = y;
        a[1, 0] = z;
        a[1, 1] = w;
    }
}