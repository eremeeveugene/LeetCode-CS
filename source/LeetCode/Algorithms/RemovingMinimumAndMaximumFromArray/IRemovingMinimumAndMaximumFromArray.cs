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

namespace LeetCode.Algorithms.RemovingMinimumAndMaximumFromArray;

/// <summary>
///     https://leetcode.com/problems/removing-minimum-and-maximum-from-array/description/
/// </summary>
public interface IRemovingMinimumAndMaximumFromArray
{
    /// <summary>
    ///     Finds the minimum number of deletions from either end of <paramref name="nums" /> needed to remove both its minimum and maximum values.
    /// </summary>
    /// <param name="nums">The array of distinct integers.</param>
    /// <returns>The minimum number of deletions required.</returns>
    int MinimumDeletions(int[] nums);
}