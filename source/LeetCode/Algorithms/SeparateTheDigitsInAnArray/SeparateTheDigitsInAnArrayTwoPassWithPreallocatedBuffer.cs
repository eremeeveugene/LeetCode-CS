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

namespace LeetCode.Algorithms.SeparateTheDigitsInAnArray;

/// <inheritdoc />
public sealed class SeparateTheDigitsInAnArrayTwoPassWithPreallocatedBuffer : ISeparateTheDigitsInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int[] SeparateDigits(int[] nums)
    {
        var totalDigits = FindTotalDigitsCount(nums);

        var result = new int[totalDigits];

        var resultIndex = 0;

        Span<int> digits = stackalloc int[10];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var digitsCount = FillDigits(num, digits);

            for (var j = digitsCount - 1; j >= 0; j--)
            {
                result[resultIndex] = digits[j];

                resultIndex++;
            }
        }

        return result;
    }

    private static int FindTotalDigitsCount(ReadOnlySpan<int> nums)
    {
        var digitsCount = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            while (num > 0)
            {
                digitsCount++;

                num /= 10;
            }
        }

        return digitsCount;
    }

    private static int FillDigits(int num, Span<int> digits)
    {
        var digitsCount = 0;

        while (num > 0)
        {
            digits[digitsCount] = num % 10;

            digitsCount++;

            num /= 10;
        }

        return digitsCount;
    }
}