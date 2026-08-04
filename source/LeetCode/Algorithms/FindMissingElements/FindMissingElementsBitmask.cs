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

namespace LeetCode.Algorithms.FindMissingElements;

/// <inheritdoc />
public sealed class FindMissingElementsBitmask : IFindMissingElements
{
    private const int BitsPerWord = 64;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public IList<int> FindMissingElements(int[] nums)
    {
        var n = nums.Length;

        var lowSeenBits = 0UL;
        var highSeenBits = 0UL;

        var min = int.MaxValue;
        var max = int.MinValue;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num < BitsPerWord)
            {
                lowSeenBits |= 1UL << num;
            }
            else
            {
                highSeenBits |= 1UL << (num - BitsPerWord);
            }

            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        var missingElements = new List<int>();

        for (var candidate = min + 1; candidate < max; candidate++)
        {
            ulong seenBit;

            if (candidate < BitsPerWord)
            {
                seenBit = (lowSeenBits >> candidate) & 1;
            }
            else
            {
                seenBit = (highSeenBits >> (candidate - BitsPerWord)) & 1;
            }

            if (seenBit == 0)
            {
                missingElements.Add(candidate);
            }
        }

        return missingElements;
    }
}