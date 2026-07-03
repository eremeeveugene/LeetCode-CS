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

namespace LeetCode.Algorithms.MinimumRemovalsToBalanceArray;

/// <inheritdoc />
public sealed class MinimumRemovalsToBalanceArraySlidingWindow : IMinimumRemovalsToBalanceArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinRemoval(int[] nums, int k)
    {
        Array.Sort(nums);

        var maximumBalancedLength = 0;
        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            while (nums[right] > (long)k * nums[left])
            {
                left++;
            }

            maximumBalancedLength = Math.Max(maximumBalancedLength, right - left + 1);
        }

        return nums.Length - maximumBalancedLength;
    }
}