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

namespace LeetCode.Algorithms.CountCompleteSubarraysInAnArray;

/// <inheritdoc />
public sealed class CountCompleteSubarraysInAnArrayFrequencyDictionary : ICountCompleteSubarraysInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountCompleteSubarrays(int[] nums)
    {
        var numsHashSet = new HashSet<int>(nums);

        var count = 0;

        var frequencyDictionary = new Dictionary<int, int>();

        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            if (!frequencyDictionary.TryAdd(nums[right], 1))
            {
                frequencyDictionary[nums[right]]++;
            }

            while (frequencyDictionary.Count == numsHashSet.Count)
            {
                count += nums.Length - right;

                frequencyDictionary[nums[left]]--;

                if (frequencyDictionary[nums[left]] == 0)
                {
                    frequencyDictionary.Remove(nums[left]);
                }

                left++;
            }
        }

        return count;
    }
}