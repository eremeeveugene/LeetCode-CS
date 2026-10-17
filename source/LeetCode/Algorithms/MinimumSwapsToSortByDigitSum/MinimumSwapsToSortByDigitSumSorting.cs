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

namespace LeetCode.Algorithms.MinimumSwapsToSortByDigitSum;

/// <inheritdoc />
public sealed class MinimumSwapsToSortByDigitSumSorting : IMinimumSwapsToSortByDigitSum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinSwaps(int[] nums)
    {
        var n = nums.Length;

        Span<long> keys = stackalloc long[n];
        Span<int> indices = stackalloc int[n];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            indices[i] = i;
            keys[i] = GetSortKey(num);
        }

        keys.Sort(indices);

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            while (indices[i] != i)
            {
                var j = indices[i];

                (indices[i], indices[j]) = (indices[j], indices[i]);

                result++;
            }
        }

        return result;
    }

    /// <summary>
    ///     Builds a key that orders numbers by digit sum, breaking ties by the smaller value, by packing the digit sum
    ///     into the upper 32 bits and <paramref name="num" /> into the lower 32 bits.
    /// </summary>
    /// <param name="num">The positive integer to build the key for.</param>
    /// <returns>The sort key for <paramref name="num" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log num)
    ///     Space complexity - O(1)
    /// </remarks>
    private static long GetSortKey(int num)
    {
        var digitSum = GetDigitSum(num);

        return ((long)digitSum << 32) | (uint)num;
    }

    /// <summary>
    ///     Computes the sum of the decimal digits of <paramref name="num" />.
    /// </summary>
    /// <param name="num">The positive integer whose digits are summed.</param>
    /// <returns>The sum of the digits of <paramref name="num" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log num)
    ///     Space complexity - O(1)
    /// </remarks>
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