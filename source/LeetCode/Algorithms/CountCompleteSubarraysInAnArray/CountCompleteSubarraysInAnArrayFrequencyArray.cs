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

namespace LeetCode.Algorithms.CountCompleteSubarraysInAnArray;

/// <inheritdoc />
public class CountCompleteSubarraysInAnArrayFrequencyArray : ICountCompleteSubarraysInAnArray
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int CountCompleteSubarrays(int[] nums)
    {
        var distinctCount = 0;
        var distinctArray = new bool[2000];

        foreach (var num in nums)
        {
            if (distinctArray[num - 1])
            {
                continue;
            }

            distinctArray[num - 1] = true;

            distinctCount++;
        }

        var count = 0;

        var frequencyArray = new int[2000];

        var left = 0;
        var currentDistinctCount = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            var rightValue = nums[right] - 1;

            if (frequencyArray[rightValue] == 0)
            {
                currentDistinctCount++;
            }

            frequencyArray[rightValue]++;

            while (currentDistinctCount == distinctCount)
            {
                count += nums.Length - right;

                frequencyArray[nums[left] - 1]--;

                if (frequencyArray[nums[left] - 1] == 0)
                {
                    currentDistinctCount--;
                }

                left++;
            }
        }

        return count;
    }
}