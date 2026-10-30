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

namespace LeetCode.Algorithms.AddToArrayFormOfInteger;

/// <inheritdoc />
public sealed class AddToArrayFormOfIntegerSummation : IAddToArrayFormOfInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(max(n, log k)), where n is the length of the array num and log k is the number of digits in the
    ///     integer k
    ///     Space complexity - O(max(n, log k)), where n is the length of the array num and log k is the number of digits in
    ///     the integer k
    /// </remarks>
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var result = new List<int>();

        var kString = k.ToString(CultureInfo.InvariantCulture);
        var kIndex = kString.Length - 1;
        var numIndex = num.Length - 1;

        var carry = 0;

        while (numIndex >= 0 || kIndex >= 0)
        {
            var val1 = 0;

            if (numIndex >= 0)
            {
                val1 = num[numIndex];
                numIndex--;
            }

            var val2 = 0;

            if (kIndex >= 0)
            {
                val2 = GetDigit(kString[kIndex]);
                kIndex--;
            }

            var sum = val1 + val2 + carry;

            if (sum >= 10)
            {
                sum -= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            result.Add(sum);
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        result.Reverse();

        return result;
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