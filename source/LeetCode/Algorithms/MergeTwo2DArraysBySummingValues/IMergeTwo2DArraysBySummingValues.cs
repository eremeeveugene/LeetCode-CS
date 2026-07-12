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

namespace LeetCode.Algorithms.MergeTwo2DArraysBySummingValues;

/// <summary>
///     /https://leetcode.com/problems/merge-two-2d-arrays-by-summing-values/description/
/// </summary>
public interface IMergeTwo2DArraysBySummingValues
{
    /// <summary>
    ///     Merges the two sorted 2D arrays <paramref name="nums1" /> and <paramref name="nums2" />, each entry being
    ///     an [id, value] pair, by summing the values that share the same id and keeping the result sorted by id.
    /// </summary>
    /// <param name="nums1">The first sorted array of [id, value] pairs with unique ids.</param>
    /// <param name="nums2">The second sorted array of [id, value] pairs with unique ids.</param>
    /// <returns>The merged, sorted array of [id, value] pairs with summed values.</returns>
    int[][] MergeArrays(int[][] nums1, int[][] nums2);
}