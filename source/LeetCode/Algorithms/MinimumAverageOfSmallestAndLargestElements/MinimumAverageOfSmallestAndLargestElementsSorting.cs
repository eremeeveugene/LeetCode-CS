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

namespace LeetCode.Algorithms.MinimumAverageOfSmallestAndLargestElements;

/// <inheritdoc />
public sealed class MinimumAverageOfSmallestAndLargestElementsSorting : IMinimumAverageOfSmallestAndLargestElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </remarks>
    public double MinimumAverage(int[] nums)
    {
        Array.Sort(nums);

        var n = nums.Length;

        var minimumAverage = double.MaxValue;

        var left = 0;
        var right = n - 1;

        while (left < right)
        {
            var leftNum = nums[left];
            var rightNum = nums[right];

            var average = (leftNum + rightNum) / 2.0;

            minimumAverage = Math.Min(minimumAverage, average);

            left++;
            right--;
        }

        return minimumAverage;
    }
}