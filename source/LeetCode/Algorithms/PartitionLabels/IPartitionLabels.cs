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

namespace LeetCode.Algorithms.PartitionLabels;

/// <summary>
///     https://leetcode.com/problems/partition-labels/description/
/// </summary>
public interface IPartitionLabels
{
    /// <summary>
    ///     Partitions <paramref name="s" /> into as many parts as possible so that each letter appears in at most one
    ///     part.
    /// </summary>
    /// <param name="s">The string to partition.</param>
    /// <returns>A list of the sizes of each partition, in order.</returns>
    IList<int> PartitionLabels(string s);
}