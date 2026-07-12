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

namespace LeetCode.Algorithms.PartitionEqualSubsetSum;

/// <summary>
///     https://leetcode.com/problems/partition-equal-subset-sum/description/
/// </summary>
public interface IPartitionEqualSubsetSum
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> can be partitioned into two subsets whose sums are equal.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <returns><see langword="true" /> if such a partition exists; otherwise, <see langword="false" />.</returns>
    bool CanPartition(int[] nums);
}