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

namespace LeetCode.Algorithms.DigitFrequencyScore;

/// <inheritdoc />
public sealed class DigitFrequencyScoreCounting : IDigitFrequencyScore
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int DigitFrequencyScore(int n)
    {
        Span<byte> digitsFrequency = stackalloc byte[10];

        while (n > 0)
        {
            var digit = n % 10;

            digitsFrequency[digit]++;

            n /= 10;
        }

        var result = 0;

        for (var digit = 1; digit < 10; digit++)
        {
            var digitFrequency = digitsFrequency[digit];

            result += digit * digitFrequency;
        }

        return result;
    }
}