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

namespace LeetCode.Algorithms.CountSubarraysWithFixedBounds;

/// <inheritdoc />
public class CountSubarraysWithFixedBoundsSlidingWindow : ICountSubarraysWithFixedBounds
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="minK"></param>
    /// <param name="maxK"></param>
    /// <returns></returns>
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        long count = 0;

        var lastMinKPosition = -1;
        var lastMaxKPosition = -1;

        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] == minK)
            {
                lastMinKPosition = right;
            }

            if (nums[right] == maxK)
            {
                lastMaxKPosition = right;
            }

            if (nums[right] < minK || nums[right] > maxK)
            {
                left = right + 1;
            }

            if (lastMinKPosition != -1 && lastMaxKPosition != -1)
            {
                count += Math.Max(0, Math.Min(lastMinKPosition, lastMaxKPosition) - left + 1);
            }
        }

        return count;
    }
}