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

namespace LeetCode.Algorithms.ShortestSubarrayWithORAtLeastK2;

/// <inheritdoc />
public sealed class ShortestSubarrayWithORAtLeastK2SlidingWindow : IShortestSubarrayWithORAtLeastK2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumSubarrayLength(int[] nums, int k)
    {
        var minLength = int.MaxValue;
        var windowStart = 0;
        var windowEnd = 0;
        var bitCounts = new int[32];

        while (windowEnd < nums.Length)
        {
            UpdateBitCounts(bitCounts, nums[windowEnd], 1);

            while (windowStart <= windowEnd && ConvertBitCountsToNumber(bitCounts) >= k)
            {
                minLength = Math.Min(minLength, windowEnd - windowStart + 1);

                UpdateBitCounts(bitCounts, nums[windowStart], -1);

                windowStart++;
            }

            windowEnd++;
        }

        return minLength == int.MaxValue ? -1 : minLength;
    }

    private static void UpdateBitCounts(int[] bitCounts, int number, int delta)
    {
        for (var bitPosition = 0; bitPosition < 32; bitPosition++)
        {
            if (((number >> bitPosition) & 1) != 0)
            {
                bitCounts[bitPosition] += delta;
            }
        }
    }

    private static int ConvertBitCountsToNumber(int[] bitCounts)
    {
        var result = 0;

        for (var bitPosition = 0; bitPosition < 32; bitPosition++)
        {
            if (bitCounts[bitPosition] != 0)
            {
                result |= 1 << bitPosition;
            }
        }

        return result;
    }
}