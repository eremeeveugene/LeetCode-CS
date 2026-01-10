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

namespace LeetCode.Algorithms.CountTheNumberOfGoodSubarrays;

/// <inheritdoc />
public sealed class CountTheNumberOfGoodSubarraysTwoPointers : ICountTheNumberOfGoodSubarrays
{
    public long CountGood(int[] nums, int k)
    {
        long result = 0;

        var frequencyDictionary = new Dictionary<int, int>();

        var pairsCount = 0;
        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            if (!frequencyDictionary.TryAdd(nums[right], 1))
            {
                pairsCount += frequencyDictionary[nums[right]];

                frequencyDictionary[nums[right]]++;
            }

            while (pairsCount >= k && left <= right)
            {
                result += nums.Length - right;

                frequencyDictionary[nums[left]]--;

                pairsCount -= frequencyDictionary[nums[left]];

                left++;
            }
        }

        return result;
    }
}