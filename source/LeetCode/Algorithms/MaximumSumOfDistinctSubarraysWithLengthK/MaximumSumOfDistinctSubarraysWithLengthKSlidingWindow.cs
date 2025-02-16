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

namespace LeetCode.Algorithms.MaximumSumOfDistinctSubarraysWithLengthK;

/// <inheritdoc />
public class MaximumSumOfDistinctSubarraysWithLengthKSlidingWindow : IMaximumSumOfDistinctSubarraysWithLengthK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public long MaximumSubarraySum(int[] nums, int k)
    {
        long maxSum = 0;
        long currentSum = 0;
        var hashSet = new HashSet<int>();

        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            while (hashSet.Contains(nums[right]))
            {
                hashSet.Remove(nums[left]);
                currentSum -= nums[left];

                left++;
            }

            hashSet.Add(nums[right]);
            currentSum += nums[right];

            if (right - left + 1 != k)
            {
                continue;
            }

            maxSum = Math.Max(maxSum, currentSum);

            hashSet.Remove(nums[left]);
            currentSum -= nums[left];

            left++;
        }

        return maxSum;
    }
}