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

namespace LeetCode.Algorithms.CountTheNumberOfFairPairs;

/// <inheritdoc />
public sealed class CountTheNumberOfFairPairsTwoPointers : ICountTheNumberOfFairPairs
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="lower"></param>
    /// <param name="upper"></param>
    /// <returns></returns>
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);

        return CountPairsAtMost(nums, upper) - CountPairsAtMost(nums, lower - 1);
    }

    private static long CountPairsAtMost(int[] nums, int threshold)
    {
        long count = 0;

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] + nums[right] > threshold)
            {
                right--;
            }
            else
            {
                count += right - left;

                left++;
            }
        }

        return count;
    }
}