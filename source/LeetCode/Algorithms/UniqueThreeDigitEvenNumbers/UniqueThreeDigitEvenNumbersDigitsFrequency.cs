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

namespace LeetCode.Algorithms.UniqueThreeDigitEvenNumbers;

/// <inheritdoc />
public sealed class UniqueThreeDigitEvenNumbersDigitsFrequency : IUniqueThreeDigitEvenNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int TotalNumbers(int[] digits)
    {
        var digitsFrequency = new int[10];

        foreach (var digit in digits)
        {
            digitsFrequency[digit]++;
        }

        var count = 0;

        for (var i = 1; i <= 9; i++)
        {
            for (var j = 0; j <= 9; j++)
            {
                for (var k = 0; k <= 9; k += 2)
                {
                    if (CanFormNumber(digitsFrequency, i, j, k))
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    private static bool CanFormNumber(int[] digitsFrequency, int hundreds, int tens, int units)
    {
        digitsFrequency[hundreds]--;
        digitsFrequency[tens]--;
        digitsFrequency[units]--;

        var canForm = digitsFrequency[hundreds] >= 0 && digitsFrequency[tens] >= 0 && digitsFrequency[units] >= 0;

        digitsFrequency[hundreds]++;
        digitsFrequency[tens]++;
        digitsFrequency[units]++;

        return canForm;
    }
}