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
public sealed class FindingThreeDigitEvenNumbersBruteForce : IFindingThreeDigitEvenNumbers
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3 + M log M)
    ///     Space complexity - O(M)
    /// </remarks>
    public int[] FindEvenNumbers(int[] digits)
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

                for (var k = 0; k < digits.Length; k++)
                {
                    if (k == i || k == j || digits[k] % 2 == 1)
                    {
                        continue;
                    }

                    numbersHashSet.Add((digits[i] * 100) + (digits[j] * 10) + digits[k]);
                }
            }
        }

        var result = numbersHashSet.ToArray();

        Array.Sort(result);

        return result;
    }
}