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

namespace LeetCode.Algorithms.ThreeFibonacciSum;

/// <inheritdoc />
public sealed class ThreeFibonacciSumMath : IThreeFibonacciSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool ThreeFibonacciSum(int n)
    {
        if (n % 2 != 0)
        {
            return false;
        }

        var half = n / 2;

        return IsFibonacci(half);
    }

    /// <summary>
    ///     Determines whether <paramref name="value" /> is a Fibonacci number, using the fact that a non-negative
    ///     integer x is a Fibonacci number if and only if 5x^2 + 4 or 5x^2 - 4 is a perfect square.
    /// </summary>
    /// <param name="value">The positive integer to check.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is a Fibonacci number; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsFibonacci(long value)
    {
        var fiveSquares = 5 * value * value;

        var isFiveSquaresPlusFourPerfectSquare = IsPerfectSquare(fiveSquares + 4);
        var isFiveSquaresMinusFourPerfectSquare = IsPerfectSquare(fiveSquares - 4);

        return isFiveSquaresPlusFourPerfectSquare || isFiveSquaresMinusFourPerfectSquare;
    }

    /// <summary>
    ///     Determines whether <paramref name="value" /> is a perfect square.
    /// </summary>
    /// <param name="value">The positive integer to check.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="value" /> is a perfect square; otherwise,
    ///     <see langword="false" />.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsPerfectSquare(long value)
    {
        var root = (long)Math.Round(Math.Sqrt(value));

        return root * root == value;
    }
}