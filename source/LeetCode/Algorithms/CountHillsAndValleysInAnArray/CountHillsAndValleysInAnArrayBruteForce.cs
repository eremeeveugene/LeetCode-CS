// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
public class CountHillsAndValleysInAnArrayBruteForce : ICountHillsAndValleysInAnArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountHillValley(int[] nums)
    {
        var count = 0;

        for (var i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;
            }

            var left = 0;

            for (var j = i - 1; j >= 0; --j)
            {
                if (nums[j] > nums[i])
                {
                    left = 1;

                    break;
                }

                if (nums[j] >= nums[i])
                {
                    continue;
                }

                left = -1;

                break;
            }

            var right = 0;

            for (var j = i + 1; j < nums.Length; ++j)
            {
                if (nums[j] > nums[i])
                {
                    right = 1;

                    break;
                }

                if (nums[j] >= nums[i])
                {
                    continue;
                }

                right = -1;

                break;
            }

            if (left == right && left != 0)
            {
                count++;
            }
        }

        return count;
    }
}