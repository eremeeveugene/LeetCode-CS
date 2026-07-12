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

namespace LeetCode.Algorithms.MinimumPositiveSumSubarray;

/// <inheritdoc />
public sealed class MinimumPositiveSumSubarrayPrefixSum : IMinimumPositiveSumSubarray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * (r - l + 1))
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinimumSumSubarray(IList<int> nums, int l, int r)
    {
        var n = nums.Count;

        var prefixSum = new int[n + 1];

        for (var i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        var minimumPositiveSum = int.MaxValue;

        for (var i = 0; i <= n - l; i++)
        {
            for (var j = l; j <= Math.Min(r, n - i); j++)
            {
                var sum = prefixSum[i + j] - prefixSum[i];

                if (sum <= 0)
                {
                    continue;
                }

                minimumPositiveSum = Math.Min(minimumPositiveSum, sum);
            }
        }

        if (minimumPositiveSum == int.MaxValue)
        {
            return -1;
        }

        return minimumPositiveSum;
    }
}