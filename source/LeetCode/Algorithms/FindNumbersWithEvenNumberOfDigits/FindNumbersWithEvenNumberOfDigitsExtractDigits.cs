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

namespace LeetCode.Algorithms.FindNumbersWithEvenNumberOfDigits;

/// <inheritdoc />
public sealed class FindNumbersWithEvenNumberOfDigitsExtractDigits : IFindNumbersWithEvenNumberOfDigits
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log m)
    ///     Space complexity - O(log m)
    /// </remarks>
    public int FindNumbers(int[] nums)
    {
        var count = 0;

        foreach (var num in nums)
        {
            var number = num;

            var digits = 0;

            while (number > 0)
            {
                number /= 10;

                digits++;
            }

            if (digits % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}