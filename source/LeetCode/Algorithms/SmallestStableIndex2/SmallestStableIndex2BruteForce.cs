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

namespace LeetCode.Algorithms.SmallestStableIndex2;

/// <inheritdoc />
public sealed class SmallestStableIndex2BruteForce : ISmallestStableIndex2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FirstStableIndex(int[] nums, int k)
    {
        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            for (var j = 0; j <= i; j++)
            {
                var num = nums[j];

                max = Math.Max(max, num);
            }

            for (var j = i; j < n; j++)
            {
                var num = nums[j];

                min = Math.Min(min, num);
            }

            var instabilityScore = max - min;

            if (instabilityScore <= k)
            {
                return i;
            }
        }

        return -1;
    }
}