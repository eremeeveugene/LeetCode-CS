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

namespace LeetCode.Algorithms.FindTargetIndicesAfterSortingArray;

/// <summary>
///     https://leetcode.com/problems/find-target-indices-after-sorting-array/description/
/// </summary>
public interface IFindTargetIndicesAfterSortingArray
{
    /// <summary>
    ///     Sorts <paramref name="nums" /> in non-decreasing order and finds all indices at which <paramref name="target" /> occurs.
    /// </summary>
    /// <param name="nums">The array of integers to sort and search.</param>
    /// <param name="target">The value whose indices are sought after sorting.</param>
    /// <returns>The list of indices in the sorted array where <paramref name="target" /> occurs.</returns>
    IList<int> TargetIndices(int[] nums, int target);
}