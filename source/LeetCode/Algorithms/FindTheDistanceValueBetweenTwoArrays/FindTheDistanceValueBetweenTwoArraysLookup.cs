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

namespace LeetCode.Algorithms.FindTheDistanceValueBetweenTwoArrays;

/// <inheritdoc />
public sealed class FindTheDistanceValueBetweenTwoArraysLookup : IFindTheDistanceValueBetweenTwoArrays
{
    private const int ValueOffset = 1000;
    private const int LookupLength = 2001;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n * d + r), where n is the length of arr1, m is the length of arr2 and r is the range of values
    ///     Space complexity - O(r)
    /// </remarks>
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        var n = arr1.Length;
        var m = arr2.Length;

        Span<bool> lookup = stackalloc bool[LookupLength];

        for (var i = 0; i < m; i++)
        {
            var value = arr2[i];

            lookup[value + ValueOffset] = true;
        }

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var value = arr1[i];

            var isWithinDistance = IsWithinDistance(lookup, value + ValueOffset, d);

            if (isWithinDistance)
            {
                continue;
            }

            result++;
        }

        return result;
    }

    /// <summary>
    ///     Determines whether <paramref name="lookup" /> has a marked index at most <paramref name="d" /> away from
    ///     <paramref name="index" />.
    /// </summary>
    /// <param name="lookup">The lookup of marked values.</param>
    /// <param name="index">The index to search around.</param>
    /// <param name="d">The maximum distance from <paramref name="index" />.</param>
    /// <returns><c>true</c> if such an index exists; otherwise, <c>false</c>.</returns>
    /// <remarks>
    ///     Time complexity - O(d)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsWithinDistance(ReadOnlySpan<bool> lookup, int index, int d)
    {
        for (var i = 0; i <= d; i++)
        {
            var lowerIndex = index - i;
            var upperIndex = index + i;

            if ((lowerIndex >= 0 && lookup[lowerIndex]) || (upperIndex < LookupLength && lookup[upperIndex]))
            {
                return true;
            }
        }

        return false;
    }
}