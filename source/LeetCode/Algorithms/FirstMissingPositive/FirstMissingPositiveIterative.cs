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

namespace LeetCode.Algorithms.FirstMissingPositive;

/// <inheritdoc />
public class FirstMissingPositiveIterative : IFirstMissingPositive
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FirstMissingPositive(int[] nums)
    {
        var n = nums.Length;

        for (var i = 0; i < n; ++i)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }
        }

        for (var i = 0; i < n; ++i)
        {
            var num = Math.Abs(nums[i]);

            if (num > n)
            {
                continue;
            }

            num--;

            if (nums[num] > 0)
            {
                nums[num] = -1 * nums[num];
            }
        }

        for (var i = 0; i < n; ++i)
        {
            if (nums[i] >= 0)
            {
                return i + 1;
            }
        }

        return n + 1;
    }
}