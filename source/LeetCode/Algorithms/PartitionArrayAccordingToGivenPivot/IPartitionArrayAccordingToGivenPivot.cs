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

namespace LeetCode.Algorithms.PartitionArrayAccordingToGivenPivot;

/// <summary>
///     https://leetcode.com/problems/partition-array-according-to-given-pivot/
/// </summary>
public interface IPartitionArrayAccordingToGivenPivot
{
    /// <summary>
    ///     Rearranges <paramref name="nums" /> so that elements less than <paramref name="pivot" /> come first, elements
    ///     equal to <paramref name="pivot" /> come next, and elements greater than <paramref name="pivot" /> come last,
    ///     preserving the relative order within each group.
    /// </summary>
    /// <param name="nums">The array of integers to rearrange.</param>
    /// <param name="pivot">The pivot value used to partition the array.</param>
    /// <returns>The rearranged array partitioned around <paramref name="pivot" />.</returns>
    int[] PivotArray(int[] nums, int pivot);
}