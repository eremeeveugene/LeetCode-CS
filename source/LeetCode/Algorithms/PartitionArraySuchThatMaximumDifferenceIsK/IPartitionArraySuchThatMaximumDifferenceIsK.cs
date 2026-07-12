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

namespace LeetCode.Algorithms.PartitionArraySuchThatMaximumDifferenceIsK;

/// <summary>
///     https://leetcode.com/problems/partition-array-such-that-maximum-difference-is-k/description/
/// </summary>
public interface IPartitionArraySuchThatMaximumDifferenceIsK
{
    /// <summary>
    ///     Finds the minimum number of subsequences needed to partition <paramref name="nums" /> so that the difference
    ///     between the maximum and minimum values in each subsequence does not exceed <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to partition.</param>
    /// <param name="k">The maximum allowed difference between the largest and smallest values in a subsequence.</param>
    /// <returns>The minimum number of subsequences required.</returns>
    int PartitionArray(int[] nums, int k);
}