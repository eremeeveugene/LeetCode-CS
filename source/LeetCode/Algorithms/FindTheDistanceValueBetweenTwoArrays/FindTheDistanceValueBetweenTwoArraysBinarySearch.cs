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
public sealed class FindTheDistanceValueBetweenTwoArraysBinarySearch : IFindTheDistanceValueBetweenTwoArrays
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((n + m) log m), where n is the length of arr1 and m is the length of arr2
    ///     Space complexity - O(log m)
    /// </remarks>
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        var n = arr1.Length;
        var m = arr2.Length;

        Array.Sort(arr2);

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var value = arr1[i];

            var lowerBoundIndex = GetLowerBoundIndex(arr2, value - d);

            if (lowerBoundIndex < m && arr2[lowerBoundIndex] <= value + d)
            {
                continue;
            }

            result++;
        }

        return result;
    }

    /// <summary>
    ///     Finds the index of the first element of <paramref name="sortedNums" /> that is greater than or equal to
    ///     <paramref name="target" />.
    /// </summary>
    /// <param name="sortedNums">The array of integers sorted in ascending order.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the first matching element, or the array length if there is none.</returns>
    /// <remarks>
    ///     Time complexity - O(log m), where m is the length of sortedNums
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetLowerBoundIndex(int[] sortedNums, int target)
    {
        var left = 0;
        var right = sortedNums.Length;

        while (left < right)
        {
            var middle = left + ((right - left) / 2);

            if (sortedNums[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return left;
    }
}