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

namespace LeetCode.Algorithms.RelativeSortArray;

/// <summary>
///     https://leetcode.com/problems/relative-sort-array/
/// </summary>
public interface IRelativeSortArray
{
    /// <summary>
    ///     Sorts the elements of <paramref name="arr1" /> so that elements appearing in <paramref name="arr2" /> come
    ///     first in the same relative order as <paramref name="arr2" />, followed by the remaining elements in ascending
    ///     order.
    /// </summary>
    /// <param name="arr1">The array of integers to sort.</param>
    /// <param name="arr2">The array defining the relative order of elements it contains.</param>
    /// <returns>The elements of <paramref name="arr1" /> sorted relative to <paramref name="arr2" />.</returns>
    int[] RelativeSortArray(int[] arr1, int[] arr2);
}