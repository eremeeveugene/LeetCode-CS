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

/// <summary>
///     https://leetcode.com/problems/fibonacci-number/description/
/// </summary>
public interface IFibonacciNumber
{
    /// <summary>
    ///     Computes the <paramref name="n" />-th Fibonacci number.
    /// </summary>
    /// <param name="n">The zero-based index in the Fibonacci sequence.</param>
    /// <returns>The <paramref name="n" />-th Fibonacci number.</returns>
    int Fib(int n);
}