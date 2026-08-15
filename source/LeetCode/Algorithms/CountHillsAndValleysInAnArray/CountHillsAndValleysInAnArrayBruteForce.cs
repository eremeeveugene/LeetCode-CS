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

namespace LeetCode.Algorithms.CountHillsAndValleysInAnArray;

/// <inheritdoc />
public sealed class CountHillsAndValleysInAnArrayBruteForce : ICountHillsAndValleysInAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountHillValley(int[] nums)
    {
        var n = nums.Length;

        var count = 0;

        for (var i = 1; i < n - 1; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;
            }

            var left = nums[i - 1] > nums[i] ? 1 : -1;

            if (left == GetRightDirection(nums, i))
            {
                count++;
            }
        }

        return count;
    }

    private static int GetRightDirection(int[] nums, int i)
    {
        var n = nums.Length;

        for (var j = i + 1; j < n; j++)
        {
            if (nums[j] > nums[i])
            {
                return 1;
            }

            if (nums[j] < nums[i])
            {
                return -1;
            }
        }

        return 0;
    }
}