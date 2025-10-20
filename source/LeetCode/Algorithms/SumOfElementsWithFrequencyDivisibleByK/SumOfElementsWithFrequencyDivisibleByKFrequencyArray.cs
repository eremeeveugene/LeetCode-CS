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

namespace LeetCode.Algorithms.SumOfElementsWithFrequencyDivisibleByK;

/// <inheritdoc />
public class SumOfElementsWithFrequencyDivisibleByKFrequencyArray : ISumOfElementsWithFrequencyDivisibleByK
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int SumDivisibleByK(int[] nums, int k)
    {
        Span<int> numsFrequency = stackalloc int[101];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            numsFrequency[num]++;
        }

        var sum = 0;

        for (var i = 1; i < numsFrequency.Length; i++)
        {
            var numFrequency = numsFrequency[i];

            if (numFrequency == 0)
            {
                continue;
            }

            if (numFrequency % k == 0)
            {
                sum += i * numFrequency;
            }
        }

        return sum;
    }
}