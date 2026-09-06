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
public sealed class SmallestStableIndex2PrefixSum : ISmallestStableIndex2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FirstStableIndex(int[] nums, int k)
    {
        var n = nums.Length;

        var min = int.MaxValue;

        Span<int> suffixMin = stackalloc int[n];

        for (var i = n - 1; i >= 0; i--)
        {
            var num = nums[i];

            min = Math.Min(min, num);

            suffixMin[i] = min;
        }

        var max = int.MinValue;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            max = Math.Max(max, num);

            var instabilityScore = max - suffixMin[i];

            if (instabilityScore <= k)
            {
                return i;
            }
        }

        return -1;
    }
}