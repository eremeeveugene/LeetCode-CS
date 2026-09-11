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
public sealed class MinimumAverageOfSmallestAndLargestElementsCountingSort : IMinimumAverageOfSmallestAndLargestElements
{
    private const int MaxValue = 50;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + k)
    ///     Space complexity - O(k)
    /// </remarks>
    public double MinimumAverage(int[] nums)
    {
        var n = nums.Length;

        Span<int> numsCounts = stackalloc int[MaxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            numsCounts[num]++;
        }

        var minimumAverage = double.MaxValue;

        var left = 1;
        var right = MaxValue;

        var pair = 0;

        while (pair < n / 2)
        {
            while (numsCounts[left] == 0)
            {
                left++;
            }

            while (numsCounts[right] == 0)
            {
                right--;
            }

            var average = (left + right) / 2.0;

            minimumAverage = Math.Min(minimumAverage, average);

            numsCounts[left]--;
            numsCounts[right]--;

            pair++;
        }

        return minimumAverage;
    }
}