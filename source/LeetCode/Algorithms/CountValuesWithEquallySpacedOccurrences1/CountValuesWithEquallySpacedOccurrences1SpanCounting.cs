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
public sealed class CountValuesWithEquallySpacedOccurrences1SpanCounting : ICountValuesWithEquallySpacedOccurrences1
{
    private const int LookupSize = 128;
    private const int InvalidFrequency = int.MinValue;

    /// <inheritdoc />
    /// <remarks>
    ///     Adds a value when its third occurrence matches the established spacing and removes it on its fourth.
    ///     An invalid third occurrence sets a negative frequency so later occurrences cannot remove an uncounted value.
    ///     The array has at most 100 elements, so an invalid frequency cannot reach a positive switch case.
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSpecialIntegers(int[] nums)
    {
        Span<(int LastIndex, int Spacing, int Frequency)> occurrences = stackalloc (int, int, int)[LookupSize];

        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i] & (LookupSize - 1);

            ref var occurrence = ref occurrences[num];

            occurrence.Frequency++;

            switch (occurrence.Frequency)
            {
                case 1:
                    occurrence.LastIndex = i;

                    break;
                case 2:
                    occurrence.Spacing = i - occurrence.LastIndex;
                    occurrence.LastIndex = i;

                    break;
                case 3:
                    if (i == occurrence.LastIndex + occurrence.Spacing)
                    {
                        result++;
                    }
                    else
                    {
                        occurrence.Frequency = InvalidFrequency;
                    }

                    break;
                case 4:
                    result--;

                    break;
            }
        }

        return result;
    }
}