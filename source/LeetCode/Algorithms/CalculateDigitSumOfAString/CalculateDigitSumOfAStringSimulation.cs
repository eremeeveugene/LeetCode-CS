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

using System.Globalization;

namespace LeetCode.Algorithms.CalculateDigitSumOfAString;

/// <inheritdoc />
public sealed class CalculateDigitSumOfAStringSimulation : ICalculateDigitSumOfAString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public string DigitSum(string s, int k)
    {
        var n = s.Length;

        Span<char> digits = stackalloc char[n];

        s.CopyTo(digits);

        var length = n;

        while (length > k)
        {
            length = SumGroups(digits, length, k);
        }

        return new string(digits[..length]);
    }

    /// <summary>
    ///     Performs a single round in place: splits the first <paramref name="length" /> characters of
    ///     <paramref name="digits" /> into consecutive groups of size <paramref name="k" /> and replaces each group with
    ///     the string representation of the sum of its digits.
    /// </summary>
    /// <param name="digits">The buffer of digit characters, overwritten with the merged group digit sums.</param>
    /// <param name="length">The number of digit characters currently in use at the start of the buffer.</param>
    /// <param name="k">The size of each group.</param>
    /// <returns>The number of digit characters in use after the round.</returns>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int SumGroups(Span<char> digits, int length, int k)
    {
        var writeIndex = 0;

        for (var groupStart = 0; groupStart < length; groupStart += k)
        {
            var groupEnd = Math.Min(groupStart + k, length);

            var groupSum = 0;

            for (var i = groupStart; i < groupEnd; i++)
            {
                var digit = GetDigit(digits[i]);

                groupSum += digit;
            }

            groupSum.TryFormat(digits[writeIndex..], out var charsWritten, provider: CultureInfo.InvariantCulture);

            writeIndex += charsWritten;
        }

        return writeIndex;
    }

    /// <summary>
    ///     Converts a digit character to its numeric value.
    /// </summary>
    /// <param name="c">The digit character.</param>
    /// <returns>The numeric value of the digit.</returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetDigit(char c)
    {
        return c - '0';
    }
}