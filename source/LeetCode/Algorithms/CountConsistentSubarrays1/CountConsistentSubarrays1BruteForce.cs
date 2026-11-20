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

namespace LeetCode.Algorithms.CountConsistentSubarrays1;

/// <inheritdoc />
public sealed class CountConsistentSubarrays1BruteForce : ICountConsistentSubarrays1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountConsistent(int[] nums)
    {
        var n = nums.Length;

        var consistentSubarraysCount = 0;

        for (var startIndex = 0; startIndex < n; startIndex++)
        {
            var subarrayAnd = nums[startIndex];
            var subarrayMin = nums[startIndex];

            for (var endIndex = startIndex; endIndex < n; endIndex++)
            {
                var num = nums[endIndex];

                subarrayAnd &= num;
                subarrayMin = Math.Min(subarrayMin, num);

                if (subarrayAnd != subarrayMin)
                {
                    continue;
                }

                consistentSubarraysCount++;
            }
        }

        return consistentSubarraysCount;
    }
}