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

namespace LeetCode.Algorithms.BinaryDigitScore;

/// <inheritdoc />
public sealed class BinaryDigitScorePowersOfTwo : IBinaryDigitScore
{
    private const int MaxPowerOfTwo = 128;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log m), where m is the maximum possible value of a and b
    ///     Space complexity - O(1)
    /// </remarks>
    public int CalculateScore(int a, int b)
    {
        var aSetBitsCount = GetSetBitsCount(a);
        var bSetBitsCount = GetSetBitsCount(b);

        if (aSetBitsCount >= bSetBitsCount)
        {
            return aSetBitsCount * bSetBitsCount;
        }

        return bSetBitsCount / aSetBitsCount;
    }

    /// <summary>
    ///     Counts the set bits of a number by subtracting powers of two from the largest down, counting each power that
    ///     fits into the remaining value.
    /// </summary>
    /// <param name="number">The number whose set bits are counted.</param>
    /// <returns>The number of set bits in the binary representation of <paramref name="number" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log m), where m is the maximum possible value of the number
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetSetBitsCount(int number)
    {
        var powerOfTwo = MaxPowerOfTwo;

        var setBitsCount = 0;

        while (number > 0)
        {
            if (powerOfTwo > number)
            {
                powerOfTwo /= 2;

                continue;
            }

            number -= powerOfTwo;

            setBitsCount++;

            powerOfTwo /= 2;
        }

        return setBitsCount;
    }
}