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

namespace LeetCode.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

/// <summary>
///     https://leetcode.com/problems/minimize-the-maximum-difference-of-pairs/description/
/// </summary>
public interface IMinimizeTheMaximumDifferenceOfPairs
{
    /// <summary>
    ///     Selects <paramref name="requiredPairsCount" /> disjoint pairs of elements from <paramref name="nums" />
    ///     to minimize the maximum absolute difference among the selected pairs.
    /// </summary>
    /// <param name="nums">The array of integers to pair up.</param>
    /// <param name="requiredPairsCount">The number of disjoint pairs that must be selected.</param>
    /// <returns>The minimized maximum absolute difference among the selected pairs.</returns>
    int MinimizeMax(int[] nums, int requiredPairsCount);
}