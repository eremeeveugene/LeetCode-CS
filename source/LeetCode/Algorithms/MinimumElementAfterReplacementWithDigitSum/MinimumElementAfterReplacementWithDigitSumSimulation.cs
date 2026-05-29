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

using System.Runtime.CompilerServices;

namespace LeetCode.Algorithms.MinimumElementAfterReplacementWithDigitSum;

/// <inheritdoc />
public sealed class MinimumElementAfterReplacementWithDigitSumSimulation : IMinimumElementAfterReplacementWithDigitSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * log m), where n is the length of <paramref name="nums" /> and m is the maximum element.
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinElement(int[] nums)
    {
        var minElement = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var digitSum = GetDigitSum(num);

            minElement = Math.Min(minElement, digitSum);

            if (minElement == 1)
            {
                return 1;
            }
        }

        return minElement;
    }

    /// <summary>
    ///     Computes the sum of the decimal digits of the specified non-negative integer.
    /// </summary>
    /// <param name="num">The non-negative integer whose digit sum will be computed.</param>
    /// <returns>The sum of the decimal digits of <paramref name="num" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetDigitSum(int num)
    {
        var digitSum = 0;

        while (num > 0)
        {
            digitSum += num % 10;

            num /= 10;
        }

        return digitSum;
    }
}