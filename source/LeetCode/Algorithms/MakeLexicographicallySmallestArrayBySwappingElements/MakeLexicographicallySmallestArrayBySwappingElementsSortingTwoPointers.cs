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

namespace LeetCode.Algorithms.MakeLexicographicallySmallestArrayBySwappingElements;

/// <inheritdoc />
public sealed class MakeLexicographicallySmallestArrayBySwappingElementsSortingTwoPointers : IMakeLexicographicallySmallestArrayBySwappingElements
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        var n = nums.Length;

        Span<int> indexes = stackalloc int[n];

        for (var index = 0; index < n; index++)
        {
            indexes[index] = index;
        }

        indexes.Sort((a, b) => nums[a].CompareTo(nums[b]));

        var left = 0;

        for (var right = 0; right < n - 1; right++)
        {
            var index = indexes[right];
            var num = nums[index];

            var nextIndex = indexes[right + 1];
            var nextNum = nums[nextIndex];

            var diff = nextNum - num;

            if (diff <= limit)
            {
                continue;
            }

            RedistributeSlice(nums, indexes.Slice(left, right - left + 1));

            left = right + 1;
        }

        RedistributeSlice(nums, indexes.Slice(left, n - left));

        return nums;
    }

    /// <summary>
    ///     Redistributes the values of one swap-connected group so that its smallest values occupy its smallest original indices.
    /// </summary>
    /// <remarks>
    ///     The indices initially follow ascending value order. The method preserves that value order before sorting the indices and writing the
    ///     values back to <paramref name="nums" />.
    ///     Time complexity - O(k log k), where k is the number of indices in the slice
    ///     Space complexity - O(k)
    /// </remarks>
    /// <param name="nums">The array whose group values are redistributed.</param>
    /// <param name="sliceIndexes">The indices belonging to one swap-connected group, initially ordered by their values.</param>
    private static void RedistributeSlice(int[] nums, Span<int> sliceIndexes)
    {
        var k = sliceIndexes.Length;

        Span<int> values = stackalloc int[k];

        for (var i = 0; i < k; i++)
        {
            var sliceIndex = sliceIndexes[i];
            var num = nums[sliceIndex];

            values[i] = num;
        }

        sliceIndexes.Sort();

        for (var i = 0; i < k; i++)
        {
            var sliceIndex = sliceIndexes[i];
            var value = values[i];

            nums[sliceIndex] = value;
        }
    }
}