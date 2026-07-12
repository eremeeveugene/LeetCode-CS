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

namespace LeetCode.Algorithms.MinimumIndexOfValidSplit;

/// <summary>
///     https://leetcode.com/problems/minimum-index-of-a-valid-split/description/
/// </summary>
public interface IMinimumIndexOfValidSplit
{
    /// <summary>
    ///     Finds the minimum index at which <paramref name="nums" /> can be split into two non-empty parts, each
    ///     having the same dominant element (an element occurring more than half the length of that part) as the
    ///     whole array.
    /// </summary>
    /// <param name="nums">The array of integers to split.</param>
    /// <returns>The minimum valid split index, or -1 if no such split exists.</returns>
    int MinimumIndex(IList<int> nums);
}