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

namespace LeetCode.Algorithms.CountElementsWithMaximumFrequency;

/// <inheritdoc />
public sealed class CountElementsWithMaximumFrequencyArray : ICountElementsWithMaximumFrequency
{
    private const int MaxLength = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxFrequencyElements(int[] nums)
    {
        Span<int> numsFrequencies = stackalloc int[MaxLength];

        var maxFrequency = 0;
        var maxFrequencySum = 0;

        var numsLength = nums.Length;

        for (var i = 0; i < numsLength; i++)
        {
            var num = nums[i] - 1;

            numsFrequencies[num]++;

            var numFrequency = numsFrequencies[num];

            if (numFrequency > maxFrequency)
            {
                maxFrequency = numFrequency;
                maxFrequencySum = maxFrequency;
            }
            else if (numFrequency == maxFrequency)
            {
                maxFrequencySum += numFrequency;
            }
        }

        return maxFrequencySum;
    }
}