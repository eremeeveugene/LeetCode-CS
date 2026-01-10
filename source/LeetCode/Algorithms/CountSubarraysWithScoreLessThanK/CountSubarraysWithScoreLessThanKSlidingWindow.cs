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

namespace LeetCode.Algorithms.CountSubarraysWithScoreLessThanK;

/// <inheritdoc />
public sealed class CountSubarraysWithScoreLessThanKSlidingWindow : ICountSubarraysWithScoreLessThanK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long CountSubarrays(int[] nums, long k)
    {
        long result = 0;

        var left = 0;

        long sum = 0;

        for (var right = left; right < nums.Length; right++)
        {
            sum += nums[right];

            while (left <= right && sum * (right - left + 1) >= k)
            {
                sum -= nums[left];

                left++;
            }

            result += right - left + 1;
        }

        return result;
    }
}