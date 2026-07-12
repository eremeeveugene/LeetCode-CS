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
public sealed class MaximumDifferenceBetweenIncreasingElementsGreedy : IMaximumDifferenceBetweenIncreasingElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumDifference(int[] nums)
    {
        var maximumDifference = -1;

        var min = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
            else if (nums[i] > min)
            {
                var difference = nums[i] - min;

                maximumDifference = Math.Max(maximumDifference, difference);
            }
        }

        return maximumDifference;
    }
}