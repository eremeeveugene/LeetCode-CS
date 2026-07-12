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

namespace LeetCode.Algorithms.RemoveDuplicatesFromSortedArray2;

/// <inheritdoc />
public sealed class RemoveDuplicatesFromSortedArray2TwoPointers : IRemoveDuplicatesFromSortedArray2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        var left = 2;

        for (var right = 2; right < nums.Length; right++)
        {
            if (nums[right] == nums[left - 2])
            {
                continue;
            }

            nums[left] = nums[right];

            left++;
        }

        return left;
    }
}