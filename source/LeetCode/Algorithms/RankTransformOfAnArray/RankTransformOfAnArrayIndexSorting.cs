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

namespace LeetCode.Algorithms.RankTransformOfAnArray;

/// <inheritdoc />
public sealed class RankTransformOfAnArrayIndexSorting : IRankTransformOfAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    /// i
    public int[] ArrayRankTransform(int[] arr)
    {
        var n = arr.Length;

        if (n == 0)
        {
            return arr;
        }

        Span<int> indexes = stackalloc int[n];

        for (var i = 0; i < n; i++)
        {
            indexes[i] = i;
        }

        indexes.Sort((a, b) => arr[a].CompareTo(arr[b]));

        var firstIndex = indexes[0];

        var result = new int[n];

        result[firstIndex] = 1;

        var previousNum = arr[firstIndex];

        var rank = 1;

        for (var i = 1; i < n; i++)
        {
            var index = indexes[i];

            var num = arr[index];

            if (num != previousNum)
            {
                previousNum = arr[index];

                rank++;
            }

            result[index] = rank;
        }

        return result;
    }
}