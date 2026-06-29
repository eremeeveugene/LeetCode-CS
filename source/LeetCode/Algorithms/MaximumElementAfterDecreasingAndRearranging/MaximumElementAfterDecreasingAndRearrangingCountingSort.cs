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

namespace LeetCode.Algorithms.MaximumElementAfterDecreasingAndRearranging;

/// <inheritdoc />
public sealed class MaximumElementAfterDecreasingAndRearrangingCountingSort : IMaximumElementAfterDecreasingAndRearranging
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        var n = arr.Length;

        Span<int> numCounts = stackalloc int[n + 1];

        for (var i = 0; i < n; i++)
        {
            var num = arr[i];
            var index = Math.Min(num, n);

            numCounts[index]++;
        }

        var result = 0;

        for (var index = 1; index < numCounts.Length; index++)
        {
            var count = numCounts[index];

            result = Math.Min(result + count, index);
        }

        return result;
    }
}