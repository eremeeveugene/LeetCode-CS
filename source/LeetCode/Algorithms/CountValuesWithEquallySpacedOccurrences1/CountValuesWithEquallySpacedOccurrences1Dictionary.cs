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

namespace LeetCode.Algorithms.CountValuesWithEquallySpacedOccurrences1;

/// <inheritdoc />
public sealed class CountValuesWithEquallySpacedOccurrences1Dictionary : ICountValuesWithEquallySpacedOccurrences1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Groups occurrence indices by value in increasing order.
    ///     A value is special only when its group contains exactly three indices with equal consecutive gaps.
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int CountSpecialIntegers(int[] nums)
    {
        var n = nums.Length;

        var numberToOccurrenceIndices = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (!numberToOccurrenceIndices.TryGetValue(num, out var occurrenceIndices))
            {
                occurrenceIndices = [];

                numberToOccurrenceIndices[num] = occurrenceIndices;
            }

            occurrenceIndices.Add(i);
        }

        var result = 0;

        foreach (var occurrenceIndices in numberToOccurrenceIndices.Values)
        {
            if (occurrenceIndices.Count != 3)
            {
                continue;
            }

            var first = occurrenceIndices[0];
            var second = occurrenceIndices[1];
            var third = occurrenceIndices[2];

            var firstGap = second - first;
            var secondGap = third - second;

            if (firstGap == secondGap)
            {
                result++;
            }
        }

        return result;
    }
}