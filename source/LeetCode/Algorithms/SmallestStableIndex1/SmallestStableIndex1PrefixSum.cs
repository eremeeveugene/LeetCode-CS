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
public sealed class SmallestStableIndex1PrefixSum : ISmallestStableIndex1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FirstStableIndex(int[] nums, int k)
    {
        var n = nums.Length;

        Span<int> prefixMax = stackalloc int[n];
        Span<int> suffixMin = stackalloc int[n];

        prefixMax[0] = nums[0];

        for (var i = 1; i < n; i++)
        {
            var num = nums[i];
            var previousMax = prefixMax[i - 1];

            prefixMax[i] = Math.Max(previousMax, num);
        }

        suffixMin[n - 1] = nums[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            var num = nums[i];
            var previousMin = suffixMin[i + 1];

            suffixMin[i] = Math.Min(previousMin, num);
        }

        for (var i = 0; i < n; i++)
        {
            var instabilityScore = prefixMax[i] - suffixMin[i];

            if (instabilityScore <= k)
            {
                return i;
            }
        }

        return -1;
    }
}