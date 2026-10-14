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

namespace LeetCode.Algorithms.MaximumBeautyOfAnArrayAfterApplyingOperation;

/// <inheritdoc />
public sealed class MaximumBeautyOfAnArrayAfterApplyingOperationDifferenceArray : IMaximumBeautyOfAnArrayAfterApplyingOperation
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaximumBeauty(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        var maxBeauty = 0;
        var maxValue = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            maxValue = Math.Max(maxValue, nums[i]);
        }

        var count = new int[maxValue + 2];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            count[Math.Max(num - k, 0)]++;
            count[Math.Min(num + k + 1, maxValue + 1)]--;
        }

        var currentSum = 0;

        for (var i = 0; i < count.Length; i++)
        {
            currentSum += count[i];
            maxBeauty = Math.Max(maxBeauty, currentSum);
        }

        return maxBeauty;
    }
}