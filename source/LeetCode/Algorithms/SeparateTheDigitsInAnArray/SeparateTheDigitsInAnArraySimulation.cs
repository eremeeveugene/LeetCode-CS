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
public sealed class SeparateTheDigitsInAnArraySimulation : ISeparateTheDigitsInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log m)
    ///     Space complexity - O(log m)
    /// </remarks>
    public int[] SeparateDigits(int[] nums)
    {
        var result = new List<int>();

        Span<int> digits = stackalloc int[10];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var digitsCount = 0;

            while (num > 0)
            {
                digits[digitsCount] = num % 10;

                digitsCount++;

                num /= 10;
            }

            for (var j = digitsCount - 1; j >= 0; j--)
            {
                result.Add(digits[j]);
            }
        }

        return result.ToArray();
    }
}