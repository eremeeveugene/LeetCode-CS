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

namespace LeetCode.Algorithms.SumOfIntegersWithMaximumDigitRange;

/// <inheritdoc />
public sealed class SumOfIntegersWithMaximumDigitRangeIterative : ISumOfIntegersWithMaximumDigitRange
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * log m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxDigitRange(int[] nums)
    {
        var maxRange = -1;
        var sum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var minDigit = 9;
            var maxDigit = 0;

            var current = num;

            while (current > 0)
            {
                var digit = current % 10;

                minDigit = Math.Min(minDigit, digit);
                maxDigit = Math.Max(maxDigit, digit);

                current /= 10;
            }

            var range = maxDigit - minDigit;

            if (range > maxRange)
            {
                maxRange = range;

                sum = num;
            }
            else if (range == maxRange)
            {
                sum += num;
            }
        }

        return sum;
    }
}