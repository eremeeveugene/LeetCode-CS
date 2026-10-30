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

namespace LeetCode.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

/// <inheritdoc />
public sealed class MinimumSumOfFourDigitNumberAfterSplittingDigitsChars : IMinimumSumOfFourDigitNumberAfterSplittingDigits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinimumSum(int num)
    {
        var sortedNums = num.ToString(CultureInfo.InvariantCulture).ToCharArray();

        Array.Sort(sortedNums);

        return (GetDigit(sortedNums[0]) * 10) +
               (GetDigit(sortedNums[1]) * 10) +
               GetDigit(sortedNums[2]) +
               GetDigit(sortedNums[3]);
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