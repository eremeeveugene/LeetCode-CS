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

namespace LeetCode.Algorithms.MinimumDifferenceBetweenHighestAndLowestOfKScores;

/// <inheritdoc />
public sealed class MinimumDifferenceBetweenHighestAndLowestOfKScoresSortingSlidingWindow : IMinimumDifferenceBetweenHighestAndLowestOfKScores
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int MinimumDifference(int[] nums, int k)
    {
        if (k < 2)
        {
            return 0;
        }

        Array.Sort(nums);

        var minimumDifference = int.MaxValue;

        for (var i = 0; i < nums.Length - k + 1; i++)
        {
            var min = nums[i];
            var max = nums[i + k - 1];

            var difference = max - min;

            minimumDifference = Math.Min(minimumDifference, difference);
        }

        return minimumDifference;
    }
}