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

namespace LeetCode.Algorithms.MaximumNumberOfJumpsToReachTheLastIndex;

/// <inheritdoc />
public sealed class MaximumNumberOfJumpsToReachTheLastIndexDynamicProgramming : IMaximumNumberOfJumpsToReachTheLastIndex
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaximumJumps(int[] nums, int target)
    {
        var n = nums.Length;

        Span<int> jumpsCounts = stackalloc int[n];

        for (var i = 0; i < n - 1; i++)
        {
            if (i > 0 && jumpsCounts[i] == 0)
            {
                continue;
            }

            var numI = nums[i];

            var nextJumpsCount = jumpsCounts[i] + 1;

            for (var j = i + 1; j < n; j++)
            {
                var numJ = nums[j];

                var diff = numJ - numI;

                if (diff >= -target && diff <= target)
                {
                    jumpsCounts[j] = Math.Max(jumpsCounts[j], nextJumpsCount);
                }
            }
        }

        var maximumJumps = jumpsCounts[^1];

        return maximumJumps == 0 ? -1 : maximumJumps;
    }
}