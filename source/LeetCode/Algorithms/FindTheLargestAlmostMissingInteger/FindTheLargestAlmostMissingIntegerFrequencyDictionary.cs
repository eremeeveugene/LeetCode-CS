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

namespace LeetCode.Algorithms.FindTheLargestAlmostMissingInteger;

/// <inheritdoc />
public sealed class FindTheLargestAlmostMissingIntegerFrequencyDictionary : IFindTheLargestAlmostMissingInteger
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int LargestInteger(int[] nums, int k)
    {
        var n = nums.Length;

        var numToFrequencyDictionary = new Dictionary<int, int>();

        var maxNum = -1;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (!numToFrequencyDictionary.TryAdd(num, 1))
            {
                numToFrequencyDictionary[num]++;
            }

            maxNum = Math.Max(maxNum, num);
        }

        if (k == n)
        {
            return maxNum;
        }

        if (k == 1)
        {
            var result = -1;

            foreach (var (num, frequency) in numToFrequencyDictionary)
            {
                if (frequency == 1)
                {
                    result = Math.Max(result, num);
                }
            }

            return result;
        }

        var first = nums[0];
        var last = nums[^1];

        var firstCandidate = numToFrequencyDictionary[first] == 1 ? first : -1;
        var lastCandidate = numToFrequencyDictionary[last] == 1 ? last : -1;

        return Math.Max(firstCandidate, lastCandidate);
    }
}