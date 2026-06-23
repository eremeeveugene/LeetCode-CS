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

namespace LeetCode.Algorithms.NextGreaterNumericallyBalancedNumber;

/// <inheritdoc />
public sealed class NextGreaterNumericallyBalancedNumberIterative : INextGreaterNumericallyBalancedNumber
{
    private const int MaxBalancedNumber = 1224444;

    /// <summary>
    ///     Time complexity - O(k * d) where k is the number of candidates scanned past n and d is the number of digits
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int NextBeautifulNumber(int n)
    {
        var candidate = n + 1;

        while (candidate <= MaxBalancedNumber)
        {
            if (IsNumericallyBalanced(candidate))
            {
                break;
            }

            candidate++;
        }

        return candidate;
    }

    private static bool IsNumericallyBalanced(int number)
    {
        Span<int> digitCounts = stackalloc int[10];

        while (number > 0)
        {
            digitCounts[number % 10]++;

            number /= 10;
        }

        for (var digit = 0; digit < digitCounts.Length; digit++)
        {
            if (digitCounts[digit] != 0 && digitCounts[digit] != digit)
            {
                return false;
            }
        }

        return true;
    }
}