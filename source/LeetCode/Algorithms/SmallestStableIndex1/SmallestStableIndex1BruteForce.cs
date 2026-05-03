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

namespace LeetCode.Algorithms.SmallestStableIndex1;

/// <inheritdoc />
public sealed class SmallestStableIndex1BruteForce : ISmallestStableIndex1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int FirstStableIndex(int[] nums, int k)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var max = int.MinValue;

            for (var j = 0; j <= i; j++)
            {
                max = Math.Max(max, nums[j]);
            }

            var min = int.MaxValue;

            for (var j = i; j < nums.Length; j++)
            {
                min = Math.Min(min, nums[j]);
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