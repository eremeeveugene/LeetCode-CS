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

/// <summary>
///     https://leetcode.com/problems/rank-transform-of-an-array/
/// </summary>
public interface IRankTransformOfAnArray
{
    /// <summary>
    ///     Replaces each element of <paramref name="arr" /> with its rank, where equal elements share the same rank and
    ///     ranks start at 1 in ascending order of value.
    /// </summary>
    /// <param name="arr">The array of integers to rank.</param>
    /// <returns>An array of the same length as <paramref name="arr" /> containing the rank of each element.</returns>
    int[] ArrayRankTransform(int[] arr);
}