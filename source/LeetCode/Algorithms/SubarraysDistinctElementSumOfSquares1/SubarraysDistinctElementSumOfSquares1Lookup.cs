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

namespace LeetCode.Algorithms.SubarraysDistinctElementSumOfSquares1;

/// <inheritdoc />
public sealed class SubarraysDistinctElementSumOfSquares1Lookup : ISubarraysDistinctElementSumOfSquares1
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SumCounts(IList<int> nums)
    {
        var n = nums.Count;

        Span<bool> seen = stackalloc bool[MaxValue + 1];

        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            seen.Clear();

            var distinctCount = 0;

            for (var j = i; j < n; j++)
            {
                var num = nums[j];

                if (!seen[num])
                {
                    seen[num] = true;

                    distinctCount++;
                }

                sum += distinctCount * distinctCount;
            }
        }

        return sum;
    }
}