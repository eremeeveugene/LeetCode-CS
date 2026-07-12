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

namespace LeetCode.Algorithms.CountGoodNumbers;

/// <inheritdoc />
public sealed class CountGoodNumbersFastExponentiation : ICountGoodNumbers
{
    private const int Mod = 1_000_000_007;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountGoodNumbers(long n)
    {
        var evenPositions = n / 2;
        var oddPositions = n - evenPositions;

        return (int)(ModPow(5, oddPositions) * ModPow(4, evenPositions) % Mod);
    }

    private static long ModPow(long value, long exponent)
    {
        long result = 1;

        while (exponent > 0)
        {
            if (exponent % 2 == 1)
            {
                result = result * value % Mod;
            }

            value = value * value % Mod;

            exponent /= 2;
        }

        return result;
    }
}