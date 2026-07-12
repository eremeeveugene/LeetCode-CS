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
            if (digitsFrequency[i] == 0)
            {
                continue;
            }

            for (var j = 0; j <= 9; j++)
            {
                if (digitsFrequency[j] == 0)
                {
                    continue;
                }

                for (var k = 0; k <= 9; k += 2)
                {
                    if (digitsFrequency[k] == 0)
                    {
                        continue;
                    }

                    if (i == j && j == k)
                    {
                        if (digitsFrequency[i] < 3)
                        {
                            continue;
                        }
                    }
                    else if (i == j)
                    {
                        if (digitsFrequency[i] < 2 || digitsFrequency[k] < 1)
                        {
                            continue;
                        }
                    }
                    else if (i == k)
                    {
                        if (digitsFrequency[i] < 2 || digitsFrequency[j] < 1)
                        {
                            continue;
                        }
                    }
                    else if (j == k)
                    {
                        if (digitsFrequency[j] < 2 || digitsFrequency[i] < 1)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (digitsFrequency[i] < 1 || digitsFrequency[j] < 1 || digitsFrequency[k] < 1)
                        {
                            continue;
                        }
                    }

                    count++;
                }
            }
        }

        return count;
    }
}