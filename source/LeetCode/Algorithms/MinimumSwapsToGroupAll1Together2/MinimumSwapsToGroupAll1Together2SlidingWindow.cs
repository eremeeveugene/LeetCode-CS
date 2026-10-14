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

namespace LeetCode.Algorithms.MinimumSwapsToGroupAll1Together2;

/// <inheritdoc />
public sealed class MinimumSwapsToGroupAll1Together2SlidingWindow : IMinimumSwapsToGroupAll1Together2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinSwaps(int[] nums)
    {
        var totalOnes = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                totalOnes++;
            }
        }

        if (totalOnes == 0)
        {
            return 0;
        }

        var windowedArray = new int[nums.Length + totalOnes];

        Array.Copy(nums, windowedArray, nums.Length);
        Array.Copy(nums, 0, windowedArray, nums.Length, totalOnes);

        var currentZeroCount = 0;

        for (var i = 0; i < totalOnes; i++)
        {
            if (windowedArray[i] == 0)
            {
                currentZeroCount++;
            }
        }

        var minSwaps = currentZeroCount;

        for (var i = 1; i < nums.Length; i++)
        {
            if (windowedArray[i - 1] == 0)
            {
                currentZeroCount--;
            }

            if (windowedArray[i + totalOnes - 1] == 0)
            {
                currentZeroCount++;
            }

            minSwaps = Math.Min(minSwaps, currentZeroCount);
        }

        return minSwaps;
    }
}