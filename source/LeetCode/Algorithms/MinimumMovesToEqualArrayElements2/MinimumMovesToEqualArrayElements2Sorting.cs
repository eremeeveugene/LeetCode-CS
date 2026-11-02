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

namespace LeetCode.Algorithms.MinimumMovesToEqualArrayElements2;

/// <inheritdoc />
public sealed class MinimumMovesToEqualArrayElements2Sorting : IMinimumMovesToEqualArrayElements2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public int MinMoves2(int[] nums)
    {
        var n = nums.Length;

        Array.Sort(nums);

        var left = 0;
        var right = n - 1;

        var result = 0;

        while (left < right)
        {
            result += nums[right] - nums[left];

            left++;
            right--;
        }

        return result;
    }
}