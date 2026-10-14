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

namespace LeetCode.Algorithms.MinimumLimitOfBallsInBag;

/// <inheritdoc />
public sealed class MinimumLimitOfBallsInBagBinarySearch : IMinimumLimitOfBallsInBag
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log m)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumSize(int[] nums, int maxOperations)
    {
        var left = 1;
        var right = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            right = Math.Max(right, nums[i]);
        }

        while (left < right)
        {
            var mid = left + ((right - left) / 2);
            long count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];

                count += (num - 1) / mid;
            }

            if (count > maxOperations)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }
}