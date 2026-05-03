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

        Span<int> suffixMin = stackalloc int[n];

        suffixMin[^1] = nums[^1];

        for (var i = n - 2; i >= 0; i--)
        {
            suffixMin[i] = Math.Min(nums[i], suffixMin[i + 1]);
        }

        var prefixMax = nums[0];

        if (prefixMax - suffixMin[0] <= k)
        {
            return 0;
        }

        for (var i = 1; i < n; i++)
        {
            prefixMax = Math.Max(prefixMax, nums[i]);

            var instabilityScore = prefixMax - suffixMin[i];

            if (instabilityScore <= k)
            {
                return i;
            }
        }

        return -1;
    }
}