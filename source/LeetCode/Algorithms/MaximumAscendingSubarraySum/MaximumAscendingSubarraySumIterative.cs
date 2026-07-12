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

namespace LeetCode.Algorithms.MaximumAscendingSubarraySum;

/// <inheritdoc />
public sealed class MaximumAscendingSubarraySumIterative : IMaximumAscendingSubarraySum
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxAscendingSum(int[] nums)
    {
        var maxAscendingSum = nums[0];
        var currentAscendingSum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                currentAscendingSum += nums[i];
            }
            else
            {
                maxAscendingSum = Math.Max(maxAscendingSum, currentAscendingSum);

                currentAscendingSum = nums[i];
            }
        }

        return Math.Max(maxAscendingSum, currentAscendingSum);
    }
}