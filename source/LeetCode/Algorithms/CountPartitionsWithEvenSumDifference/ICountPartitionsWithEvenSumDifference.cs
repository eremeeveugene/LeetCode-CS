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

namespace LeetCode.Algorithms.CountPartitionsWithEvenSumDifference;

/// <summary>
///     https://leetcode.com/problems/count-partitions-with-even-sum-difference/description/
/// </summary>
public interface ICountPartitionsWithEvenSumDifference
{
    /// <summary>
    ///     Counts the ways to partition <paramref name="nums" /> into a non-empty prefix and suffix such that the
    ///     difference between the sum of the prefix and the sum of the suffix is even.
    /// </summary>
    /// <param name="nums">The array of integers to partition.</param>
    /// <returns>The number of partitions whose sum difference is even.</returns>
    int CountPartitions(int[] nums);
}