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
public sealed class UniqueThreeDigitEvenNumbersBruteForce : IUniqueThreeDigitEvenNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(n^3)
    /// </remarks>
    public int TotalNumbers(int[] digits)
    {
        var numbersHashSet = new HashSet<int>();

        for (var i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
            {
                continue;
            }

            for (var j = 0; j < digits.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }

                AddEvenNumbers(digits, numbersHashSet, i, j);
            }
        }

        return numbersHashSet.Count;
    }

    private static void AddEvenNumbers(int[] digits, HashSet<int> numbersHashSet, int i, int j)
    {
        for (var k = 0; k < digits.Length; k++)
        {
            if (k == i || k == j || digits[k] % 2 != 0)
            {
                continue;
            }

            numbersHashSet.Add((digits[i] * 100) + (digits[j] * 10) + digits[k]);
        }
    }
}