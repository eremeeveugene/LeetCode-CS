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

namespace LeetCode.Algorithms.MinimizeMaximumPairSumInArray;

/// <inheritdoc />
public sealed class MinimizeMaximumPairSumInArraySortingTwoPointers : IMinimizeMaximumPairSumInArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int MinPairSum(int[] nums)
    {
        Array.Sort(nums);

        var left = 0;
        var right = nums.Length - 1;

        var result = 0;

        while (left < right)
        {
            var sum = nums[left] + nums[right];

            result = Math.Max(result, sum);

            left++;
            right--;
        }

        return result;
    }
}