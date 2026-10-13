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

namespace LeetCode.Algorithms.MaximumAlternatingSumOfSquares;

/// <inheritdoc />
public sealed class MaximumAlternatingSumOfSquaresSorting : IMaximumAlternatingSumOfSquares
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public long MaxAlternatingSum(int[] nums)
    {
        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            nums[i] = num * num;
        }

        Array.Sort(nums);

        var negativeCount = n / 2;

        long result = 0;

        for (var i = 0; i < negativeCount; i++)
        {
            var num = nums[i];

            result -= num;
        }

        for (var i = negativeCount; i < n; i++)
        {
            var num = nums[i];

            result += num;
        }

        return result;
    }
}