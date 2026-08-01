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

namespace LeetCode.Algorithms.LargestIntegerWithGivenDigitSum;

/// <inheritdoc />
public sealed class LargestIntegerWithGivenDigitSumBruteForce : ILargestIntegerWithGivenDigitSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(10^n * n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int LargestInteger(int n, int s)
    {
        var largestCandidate = (int)Math.Pow(10, n) - 1;

        for (var candidate = largestCandidate; candidate >= 0; candidate--)
        {
            var digitSum = 0;

            var remainingDigits = candidate;

            while (remainingDigits > 0)
            {
                var digit = remainingDigits % 10;

                digitSum += digit;

                remainingDigits /= 10;
            }

            if (digitSum == s)
            {
                return candidate;
            }
        }

        return -1;
    }
}