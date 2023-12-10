// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.TwoSum;

/// <summary>
///     https://leetcode.com/problems/two-sum/description/
/// </summary>
public static class TwoSumDictionary
{
    /// <summary>
    ///     Time complexity - O (n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] GetResult(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (dictionary.TryGetValue(complement, out int value))
            {
                return new[] { value, i };
            }

            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary[nums[i]] = i;
            }
        }

        return Array.Empty<int>();
    }
}