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

namespace LeetCode.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum1;

/// <inheritdoc />
public sealed class ConcatenateNonZeroDigitsAndMultiplyBySum1Iterative : IConcatenateNonZeroDigitsAndMultiplyBySum1
{
    /// <summary>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public long SumAndMultiply(int n)
    {
        long value = 0;
        var sum = 0;
        var multiplier = 1;

        while (n > 0)
        {
            var digit = n % 10;

            n /= 10;

            if (digit == 0)
            {
                continue;
            }

            sum += digit;
            value += digit * multiplier;

            multiplier *= 10;
        }

        return value * sum;
    }
}