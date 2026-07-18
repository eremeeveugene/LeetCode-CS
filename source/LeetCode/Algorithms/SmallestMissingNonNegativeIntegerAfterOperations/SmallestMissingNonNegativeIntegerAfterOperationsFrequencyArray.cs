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

namespace LeetCode.Algorithms.SmallestMissingNonNegativeIntegerAfterOperations;

/// <inheritdoc />
public sealed class SmallestMissingNonNegativeIntegerAfterOperationsFrequencyArray : ISmallestMissingNonNegativeIntegerAfterOperations
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + value), where n is the length of the nums array
    ///     Space complexity - O(value)
    /// </remarks>
    public int FindSmallestInteger(int[] nums, int value)
    {
        Span<int> remainderCounts = stackalloc int[value];

        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];
            var remainder = ((num % value) + value) % value;

            remainderCounts[remainder]++;
        }

        var resultCount = int.MaxValue;
        var resultRemainder = 0;

        for (var remainder = 0; remainder < value; remainder++)
        {
            var count = remainderCounts[remainder];

            if (count >= resultCount)
            {
                continue;
            }

            resultCount = remainderCounts[remainder];
            resultRemainder = remainder;
        }

        return (resultCount * value) + resultRemainder;
    }
}