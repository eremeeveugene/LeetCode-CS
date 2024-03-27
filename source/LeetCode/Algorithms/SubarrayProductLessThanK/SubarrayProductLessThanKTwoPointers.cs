// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.SubarrayProductLessThanK;

/// <inheritdoc />
public class SubarrayProductLessThanKTwoPointers : ISubarrayProductLessThanK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1)
        {
            return 0;
        }

        var count = 0;
        var product = 1;
        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            product *= nums[right];

            while (product >= k)
            {
                product /= nums[left];

                left++;
            }

            count += right - left + 1;
        }

        return count;
    }
}