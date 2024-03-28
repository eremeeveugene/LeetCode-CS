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

namespace LeetCode.Algorithms.LengthOfLongestSubarrayWithAtMostKFrequency;

/// <inheritdoc />
public class LengthOfLongestSubarrayWithAtMostKFrequencyTwoPointers : ILengthOfLongestSubarrayWithAtMostKFrequency
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaxSubarrayLength(int[] nums, int k)
    {
        var maxLength = 0;
        var left = 0;

        var frequencyDictionary = new Dictionary<int, int>();

        for (var right = 0; right < nums.Length; right++)
        {
            if (frequencyDictionary.TryGetValue(nums[right], out var value))
            {
                frequencyDictionary[nums[right]] = ++value;
            }
            else
            {
                frequencyDictionary[nums[right]] = 1;
            }

            while (frequencyDictionary[nums[right]] > k)
            {
                frequencyDictionary[nums[left]]--;

                if (frequencyDictionary[nums[left]] == 0)
                {
                    frequencyDictionary.Remove(nums[left]);
                }

                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}