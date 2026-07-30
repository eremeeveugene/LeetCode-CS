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

namespace LeetCode.Algorithms.KthLargestElementInAnArray;

/// <inheritdoc />
public sealed class KthLargestElementInAnArrayQuickSelect : IKthLargestElementInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindKthLargest(int[] nums, int k)
    {
        var targetIndex = nums.Length - k;

        var left = 0;
        var right = nums.Length - 1;

        var result = 0;

        while (left <= right)
        {
            var pivotIndex = Partition(nums, left, right);

            if (pivotIndex == targetIndex)
            {
                result = nums[pivotIndex];

                break;
            }

            if (pivotIndex < targetIndex)
            {
                left = pivotIndex + 1;
            }
            else
            {
                right = pivotIndex - 1;
            }
        }

        return result;
    }

    private static int Partition(int[] nums, int left, int right)
    {
        var pivot = nums[right];
        var storeIndex = left;

        for (var i = left; i < right; i++)
        {
            if (nums[i] > pivot)
            {
                continue;
            }

            (nums[i], nums[storeIndex]) = (nums[storeIndex], nums[i]);

            storeIndex++;
        }

        (nums[storeIndex], nums[right]) = (nums[right], nums[storeIndex]);

        return storeIndex;
    }
}