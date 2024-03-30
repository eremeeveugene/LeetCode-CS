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

namespace LeetCode.Algorithms.SubarraysWithKDifferentIntegers;

/// <inheritdoc />
public class SubarraysWithKDifferentIntegersSlidingWindow : ISubarraysWithKDifferentIntegers
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        return AtMostKDistinct(nums, k) - AtMostKDistinct(nums, k - 1);
    }

    private static int AtMostKDistinct(IReadOnlyList<int> nums, int k)
    {
        var result = 0;

        var left = 0;

        var numDictionary = new Dictionary<int, int>();

        for (var right = 0; right < nums.Count; right++)
        {
            if (!numDictionary.TryAdd(nums[right], 1))
            {
                numDictionary[nums[right]]++;
            }

            while (numDictionary.Count > k)
            {
                numDictionary[nums[left]]--;

                if (numDictionary[nums[left]] == 0)
                {
                    numDictionary.Remove(nums[left]);
                }

                left++;
            }

            result += right - left + 1;
        }

        return result;
    }
}