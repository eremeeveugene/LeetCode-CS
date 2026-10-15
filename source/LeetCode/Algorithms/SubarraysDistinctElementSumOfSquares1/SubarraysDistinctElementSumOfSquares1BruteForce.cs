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
public sealed class SubarraysDistinctElementSumOfSquares1BruteForce : ISubarraysDistinctElementSumOfSquares1
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^3)
    ///     Space complexity - O(1)
    /// </remarks>
    public int SumCounts(IList<int> nums)
    {
        var n = nums.Count;

        Span<bool> seen = stackalloc bool[MaxValue + 1];

        var sum = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = i; j < n; j++)
            {
                seen.Clear();

                var distinctCount = 0;

                for (var k = i; k <= j; k++)
                {
                    var num = nums[k];

                    if (seen[num])
                    {
                        continue;
                    }

                    seen[num] = true;

                    distinctCount++;
                }

                sum += distinctCount * distinctCount;
            }
        }

        return sum;
    }
}