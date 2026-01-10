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

namespace LeetCode.Algorithms.FindingThreeDigitEvenNumbers;

/// <inheritdoc />
public sealed class FindingThreeDigitEvenNumbersFrequency : IFindingThreeDigitEvenNumbers
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] FindEvenNumbers(int[] digits)
    {
        var digitsFrequency = new int[10];

        foreach (var digit in digits)
        {
            digitsFrequency[digit]++;
        }

        var result = new List<int>();

        for (var i = 1; i < 10; i++)
        {
            if (digitsFrequency[i] <= 0)
            {
                continue;
            }

            digitsFrequency[i]--;

            for (var j = 0; j < 10; j++)
            {
                if (digitsFrequency[j] <= 0)
                {
                    continue;
                }

                digitsFrequency[j]--;

                for (var k = 0; k < 10; k += 2)
                {
                    if (digitsFrequency[k] > 0)
                    {
                        result.Add((i * 100) + (j * 10) + k);
                    }
                }

                digitsFrequency[j]++;
            }

            digitsFrequency[i]++;
        }

        return result.ToArray();
    }
}