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
public sealed class CountValuesWithEquallySpacedOccurrences1SpanIndexing : ICountValuesWithEquallySpacedOccurrences1
{
    private const int MaxValue = 100;

    /// <inheritdoc />
    /// <remarks>
    ///     Uses each value as an index into a stack-allocated table of occurrence counts and the first three indices.
    ///     Counts beyond three are retained to exclude values with additional occurrences.
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int CountSpecialIntegers(int[] nums)
    {
        var n = nums.Length;

        Span<(int Count, int FirstIndex, int SecondIndex, int ThirdIndex)> occurrences = stackalloc (int, int, int, int)[MaxValue + 1];

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            ref var occurrence = ref occurrences[num];

            occurrence.Count++;

            switch (occurrence.Count)
            {
                case 1:
                    occurrence.FirstIndex = i;

                    break;
                case 2:
                    occurrence.SecondIndex = i;

                    break;
                case 3:
                    occurrence.ThirdIndex = i;

                    break;
            }
        }

        var result = 0;

        var m = occurrences.Length;

        for (var i = 0; i < m; i++)
        {
            var occurrence = occurrences[i];

            if (occurrence.Count != 3)
            {
                continue;
            }

            var firstGap = occurrence.SecondIndex - occurrence.FirstIndex;
            var secondGap = occurrence.ThirdIndex - occurrence.SecondIndex;

            if (firstGap == secondGap)
            {
                result++;
            }
        }

        return result;
    }
}