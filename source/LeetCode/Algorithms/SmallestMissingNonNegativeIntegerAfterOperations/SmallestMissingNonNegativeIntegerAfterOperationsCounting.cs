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
public sealed class SmallestMissingNonNegativeIntegerAfterOperationsCounting : ISmallestMissingNonNegativeIntegerAfterOperations
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + value), where n is the length of the nums array
    ///     Space complexity - O(value)
    /// </remarks>
    public int FindSmallestInteger(int[] nums, int value)
    {
        var remainderToCountDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            var remainder = ((num % value) + value) % value;

            if (!remainderToCountDictionary.TryAdd(remainder, 1))
            {
                remainderToCountDictionary[remainder]++;
            }
        }

        var result = 0;
        var resultRemainder = 0;

        while (remainderToCountDictionary.TryGetValue(resultRemainder, out var count) && count > 0)
        {
            remainderToCountDictionary[resultRemainder] = count - 1;

            result++;

            resultRemainder = result % value;
        }

        return result;
    }
}