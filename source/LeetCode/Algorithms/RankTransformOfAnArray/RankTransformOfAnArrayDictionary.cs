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
        var sortedNums = arr.Distinct().Order().ToArray();

        var rankDictionary = new Dictionary<int, int>();

        for (var rank = 0; rank < sortedNums.Length; rank++)
        {
            rankDictionary.Add(sortedNums[rank], rank + 1);
        }

        for (var i = 0; i < arr.Length; i++)
        {
            arr[i] = rankDictionary[arr[i]];
        }

        return arr;
    }
}