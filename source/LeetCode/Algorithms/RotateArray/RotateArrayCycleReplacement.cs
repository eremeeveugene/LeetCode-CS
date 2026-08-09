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

namespace LeetCode.Algorithms.RotateArray;

/// <inheritdoc />
public sealed class RotateArrayCycleReplacement : IRotateArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;

        k %= n;

        if (k == 0)
        {
            return;
        }

        var count = 0;

        for (var i = 0; i < n; i++)
        {
            if (count >= n)
            {
                break;
            }

            var currentIndex = i;
            var previousValue = nums[i];

            do
            {
                var nextIndex = (currentIndex + k) % n;

                (nums[nextIndex], previousValue) = (previousValue, nums[nextIndex]);

                currentIndex = nextIndex;

                count++;
            } while (currentIndex != i);
        }
    }
}