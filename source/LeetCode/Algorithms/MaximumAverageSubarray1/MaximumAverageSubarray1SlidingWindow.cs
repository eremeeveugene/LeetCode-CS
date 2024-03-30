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

namespace LeetCode.Algorithms.MaximumAverageSubarray1;

/// <inheritdoc />
public class MaximumAverageSubarray1SlidingWindow : IMaximumAverageSubarray1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public double FindMaxAverage(int[] nums, int k)
    {
        var maxAverage = double.MinValue;

        var left = 0;

        var average = 0.0;

        for (var right = 0; right < nums.Length; right++)
        {
            average += nums[right];

            if (right - left + 1 > k)
            {
                average -= nums[left];

                left++;
            }

            if (right - left + 1 == k)
            {
                maxAverage = Math.Max(maxAverage, average);
            }
        }

        return maxAverage / k;
    }
}