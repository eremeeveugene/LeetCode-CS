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

namespace LeetCode.Algorithms.SmallestDivisibleDigitProduct1;

/// <inheritdoc />
public sealed class SmallestDivisibleDigitProduct1BruteForce : ISmallestDivisibleDigitProduct1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SmallestNumber(int n, int t)
    {
        var candidate = n;

        while (DigitProduct(candidate) % t != 0)
        {
            candidate++;
        }

        return candidate;
    }

    /// <summary>
    ///     Computes the product of the decimal digits of <paramref name="number" />.
    /// </summary>
    /// <param name="number">The number whose digits are multiplied together.</param>
    /// <returns>The product of the digits of <paramref name="number" />.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int DigitProduct(int number)
    {
        var product = 1;

        while (number > 0)
        {
            var digit = number % 10;

            product *= digit;

            number /= 10;
        }

        return product;
    }
}