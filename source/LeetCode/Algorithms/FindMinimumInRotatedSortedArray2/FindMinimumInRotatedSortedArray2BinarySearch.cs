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

namespace LeetCode.Algorithms.FindMinimumInRotatedSortedArray2;

/// <inheritdoc />
public sealed class FindMinimumInRotatedSortedArray2BinarySearch : IFindMinimumInRotatedSortedArray2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FindMin(int[] nums)
    {
        var n = nums.Length;

        var left = 0;
        var right = n - 1;

        while (left < right)
        {
            var mid = left + ((right - left) / 2);

            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else if (nums[mid] < nums[right])
            {
                right = mid;
            }
            else
            {
                right--;
            }
        }

        return nums[left];
    }
}