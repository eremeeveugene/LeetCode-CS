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

namespace LeetCode.Algorithms.FindPivotIndex;

/// <summary>
///     https://leetcode.com/problems/find-pivot-index/
/// </summary>
public interface IFindPivotIndex
{
    /// <summary>
    ///     Finds the leftmost pivot index of <paramref name="nums" />, the index where the sum of the elements to its left
    ///     equals the sum of the elements to its right.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The leftmost pivot index, or -1 if none exists.</returns>
    int PivotIndex(int[] nums);
}