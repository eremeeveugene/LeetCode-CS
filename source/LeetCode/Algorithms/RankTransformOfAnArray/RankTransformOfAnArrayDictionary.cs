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
public sealed class RankTransformOfAnArrayDictionary : IRankTransformOfAnArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] ArrayRankTransform(int[] arr)
    {
        var sortedNums = new int[arr.Length];

        Array.Copy(arr, sortedNums, arr.Length);
        Array.Sort(sortedNums);

        var rankDictionary = new Dictionary<int, int>();

        var rank = 0;

        for (var i = 0; i < sortedNums.Length; i++)
        {
            var num = sortedNums[i];

            if (i > 0 && num == sortedNums[i - 1])
            {
                continue;
            }

            rank++;

            rankDictionary.Add(num, rank);
        }

        for (var i = 0; i < arr.Length; i++)
        {
            arr[i] = rankDictionary[arr[i]];
        }

        return arr;
    }
}