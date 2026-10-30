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

namespace LeetCode.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

/// <inheritdoc />
public sealed class SubtractTheProductAndSumOfDigitsOfAnIntegerString : ISubtractTheProductAndSumOfDigitsOfAnInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(d), where d is the number of digits in the integer n
    ///     Space complexity - O(d), where d is the number of digits in the integer n
    /// </remarks>
    public int SubtractProductAndSum(int n)
    {
        var productOfDigits = 1;
        var sumOfDigits = 0;

        var digits = n.ToString(CultureInfo.InvariantCulture);

        for (var i = 0; i < digits.Length; i++)
        {
            var numericValue = GetDigit(digits[i]);

            productOfDigits *= numericValue;
            sumOfDigits += numericValue;
        }

        return productOfDigits - sumOfDigits;
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