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

namespace LeetCode.Algorithms.FindXValueOfArray1;

/// <inheritdoc />
public sealed class FindXValueOfArray1DynamicProgramming : IFindXValueOfArray1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * k)
    ///     Space complexity - O(k)
    /// </remarks>
    public long[] ResultArray(int[] nums, int k)
    {
        var n = nums.Length;

        var result = new long[k];

        Span<long> previousRemainderCounts = stackalloc long[k];
        Span<long> currentRemainderCounts = stackalloc long[k];

        previousRemainderCounts.Clear();

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            var numRemainder = num % k;

            currentRemainderCounts.Clear();
            currentRemainderCounts[numRemainder] = 1;

            for (var remainder = 0; remainder < k; remainder++)
            {
                var productRemainder = remainder * numRemainder % k;

                currentRemainderCounts[productRemainder] += previousRemainderCounts[remainder];
            }

            for (var remainder = 0; remainder < k; remainder++)
            {
                var count = currentRemainderCounts[remainder];

                result[remainder] += count;
                previousRemainderCounts[remainder] = count;
            }
        }

        return result;
    }
}