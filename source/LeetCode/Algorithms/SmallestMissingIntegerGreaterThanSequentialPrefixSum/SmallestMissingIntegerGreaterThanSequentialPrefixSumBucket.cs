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

namespace LeetCode.Algorithms.SmallestMissingIntegerGreaterThanSequentialPrefixSum;

/// <inheritdoc />
public sealed class SmallestMissingIntegerGreaterThanSequentialPrefixSumBucket : ISmallestMissingIntegerGreaterThanSequentialPrefixSum
{
    private const int MaxValue = 50;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of nums
    ///     Space complexity - O(n), where n is the length of nums
    /// </remarks>
    public int MissingInteger(int[] nums)
    {
        var n = nums.Length;

        var prefixSum = nums[0];

        var i = 1;

        while (i < n)
        {
            var num = nums[i];
            var previousNum = nums[i - 1];

            if (num - previousNum != 1)
            {
                break;
            }

            prefixSum += num;

            i++;
        }

        var numsLookupSize = Math.Max(prefixSum, MaxValue) + n + 1;

        Span<bool> numsLookup = stackalloc bool[numsLookupSize];

        for (var j = 0; j < n; j++)
        {
            var num = nums[j];

            numsLookup[num] = true;
        }

        var missingInteger = prefixSum;

        while (numsLookup[missingInteger])
        {
            missingInteger++;
        }

        return missingInteger;
    }
}