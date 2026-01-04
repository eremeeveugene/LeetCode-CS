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

namespace LeetCode.Algorithms.ContinuousSubarrays;

/// <inheritdoc />
public class ContinuousSubarraysTwoPointers : IContinuousSubarrays
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public long ContinuousSubarrays(int[] nums)
    {
        long result = 0;

        var left = 0;
        var right = 0;

        long windowLength;

        var currentMin = nums[right];
        var currentMax = nums[right];

        for (right = 0; right < nums.Length; right++)
        {
            currentMin = Math.Min(currentMin, nums[right]);
            currentMax = Math.Max(currentMax, nums[right]);

            if (currentMax - currentMin <= 2)
            {
                continue;
            }

            windowLength = right - left;
            result += windowLength * (windowLength + 1) / 2;

            left = right;
            currentMin = currentMax = nums[right];

            while (left > 0 && Math.Abs(nums[right] - nums[left - 1]) <= 2)
            {
                left--;

                currentMin = Math.Min(currentMin, nums[left]);
                currentMax = Math.Max(currentMax, nums[left]);
            }

            if (left >= right)
            {
                continue;
            }

            windowLength = right - left;
            result -= windowLength * (windowLength + 1) / 2;
        }

        windowLength = right - left;
        result += windowLength * (windowLength + 1) / 2;

        return result;
    }
}