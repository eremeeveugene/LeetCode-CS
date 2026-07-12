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

namespace LeetCode.Algorithms.MinimumPairRemovalToSortArray1;

/// <summary>
///     https://leetcode.com/problems/minimum-pair-removal-to-sort-array-i/description/
/// </summary>
public interface IMinimumPairRemovalToSortArray1
{
    /// <summary>
    ///     Finds the minimum number of operations needed to make <paramref name="nums" /> non-decreasing, where each
    ///     operation replaces the adjacent pair with the smallest sum by that sum.
    /// </summary>
    /// <param name="nums">The array of integers to sort into non-decreasing order.</param>
    /// <returns>The minimum number of pair-removal operations required.</returns>
    int MinimumPairRemoval(int[] nums);
}