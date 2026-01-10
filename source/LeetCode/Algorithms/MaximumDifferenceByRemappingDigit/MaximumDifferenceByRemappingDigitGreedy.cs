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

namespace LeetCode.Algorithms.MaximumDifferenceByRemappingDigit;

/// <inheritdoc />
public sealed class MaximumDifferenceByRemappingDigitGreedy : IMaximumDifferenceByRemappingDigit
{
    /// <summary>
    ///     Time complexity - O(log num)
    ///     Space complexity - O(log num)
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int MinMaxDifference(int num)
    {
        var digits = num.ToString();

        var targetMax = digits.FirstOrDefault(digit => digit != '9');

        var max = 0;

        foreach (var digit in digits)
        {
            max *= 10;

            if (digit == targetMax)
            {
                max += 9;
            }
            else
            {
                max += digit - '0';
            }
        }

        var targetMin = digits[0];

        var min = 0;

        foreach (var digit in digits)
        {
            min *= 10;

            if (digit == targetMin)
            {
                min += 0;
            }
            else
            {
                min += digit - '0';
            }
        }

        return max - min;
    }
}