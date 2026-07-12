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

namespace LeetCode.Algorithms.MaximumDifferenceBetweenIncreasingElements;

/// <inheritdoc />
public sealed class MaximumDifferenceBetweenIncreasingElementsBruteForce : IMaximumDifferenceBetweenIncreasingElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumDifference(int[] nums)
    {
        var maximumDifference = -1;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] >= nums[j])
                {
                    continue;
                }

                var difference = nums[j] - nums[i];

                maximumDifference = Math.Max(maximumDifference, difference);
            }
        }

        return maximumDifference;
    }
}