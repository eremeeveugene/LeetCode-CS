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

namespace LeetCode.Algorithms.SmallestRange1;

/// <inheritdoc />
public sealed class SmallestRange1Greedy : ISmallestRange1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SmallestRangeI(int[] nums, int k)
    {
        var min = nums[0];
        var max = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        return Math.Max(0, max - min - (2 * k));
    }
}