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

namespace LeetCode.Algorithms.EqualSumGridPartition1;

/// <summary>
///     https://leetcode.com/problems/equal-sum-grid-partition-i/description/
/// </summary>
public interface IEqualSumGridPartition1
{
    /// <summary>
    ///     Determines whether <paramref name="grid" /> can be partitioned into two parts, by removing a single cell if
    ///     necessary, using one horizontal or vertical cut such that the sum of each part is equal.
    /// </summary>
    /// <param name="grid">The 2-dimensional array of integers to partition.</param>
    /// <returns><see langword="true" /> if such a partition exists; otherwise, <see langword="false" />.</returns>
    bool CanPartitionGrid(int[][] grid);
}