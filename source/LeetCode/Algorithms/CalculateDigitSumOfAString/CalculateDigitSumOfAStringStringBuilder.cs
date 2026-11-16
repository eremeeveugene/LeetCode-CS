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

using System.Text;

namespace LeetCode.Algorithms.CalculateDigitSumOfAString;

/// <inheritdoc />
public sealed class CalculateDigitSumOfAStringStringBuilder : ICalculateDigitSumOfAString
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public string DigitSum(string s, int k)
    {
        var roundResultBuilder = new StringBuilder();

        while (s.Length > k)
        {
            var n = s.Length;

            roundResultBuilder.Clear();

            for (var groupStart = 0; groupStart < n; groupStart += k)
            {
                var groupEnd = Math.Min(groupStart + k, n);

                var groupSum = 0;

                for (var i = groupStart; i < groupEnd; i++)
                {
                    var digit = GetDigit(s[i]);

                    groupSum += digit;
                }

                roundResultBuilder.Append(groupSum);
            }

            s = roundResultBuilder.ToString();
        }

        return s;
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