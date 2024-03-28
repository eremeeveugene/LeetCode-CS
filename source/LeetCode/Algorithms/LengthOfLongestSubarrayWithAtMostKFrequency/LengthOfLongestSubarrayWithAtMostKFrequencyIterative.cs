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
public class LengthOfLongestSubarrayWithAtMostKFrequencyIterative : ILengthOfLongestSubarrayWithAtMostKFrequency
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MaxSubarrayLength(int[] nums, int k)
    {
        var maxLength = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var dictionary = new Dictionary<int, int>();

            for (var j = i; j < nums.Length; j++)
            {
                if (dictionary.TryAdd(nums[j], 1))
                {
                    continue;
                }

                if (dictionary[nums[j]] == k)
                {
                    maxLength = Math.Max(maxLength, j - i);

                    break;
                }

                dictionary[nums[j]]++;
            }

            maxLength = Math.Max(maxLength, dictionary.Select(d => d.Value).Sum());
        }

        return maxLength;
    }
}