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

namespace LeetCode.Algorithms.MinimumSumOfSquaredDifference;

/// <inheritdoc />
public sealed class MinimumSumOfSquaredDifferenceCounting : IMinimumSumOfSquaredDifference
{
    private const int MaxNum = 100_000;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of nums1 and nums2
    ///     Space complexity - O(1)
    /// </remarks>
    public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
    {
        var n = nums1.Length;

        const int m = MaxNum + 1;

        Span<long> diffCounts = stackalloc long[m];

        for (var i = 0; i < n; i++)
        {
            var num1 = nums1[i];
            var num2 = nums2[i];

            var diff = Math.Abs(num1 - num2);

            diffCounts[diff]++;
        }

        long k = k1 + k2;

        long result = 0;

        for (var i = m - 1; i >= 1; i--)
        {
            var diffCount = diffCounts[i];

            var moved = Math.Min(diffCount, k);

            k -= moved;

            diffCounts[i - 1] += moved;

            result += (diffCount - moved) * i * i;
        }

        return result;
    }
}