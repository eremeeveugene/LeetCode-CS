// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class UniqueThreeDigitEvenNumbersBruteForce : IUniqueThreeDigitEvenNumbers
{
    /// <summary>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n^3)
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int TotalNumbers(int[] digits)
    {
        var numbersHashSet = new HashSet<int>();

        for (var i = 0; i < digits.Length; i++)
        {
            for (var j = 0; j < digits.Length; j++)
            {
                for (var k = 0; k < digits.Length; k++)
                {
                    if (i == j || i == k || j == k)
                    {
                        continue;
                    }

                    if (digits[i] == 0 || digits[k] % 2 != 0)
                    {
                        continue;
                    }

                    numbersHashSet.Add((digits[i] * 100) + (digits[j] * 10) + digits[k]);
                }
            }
        }

        return numbersHashSet.Count;
    }
}