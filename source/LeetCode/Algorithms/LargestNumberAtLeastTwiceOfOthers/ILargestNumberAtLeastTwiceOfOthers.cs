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

namespace LeetCode.Algorithms.LargestNumberAtLeastTwiceOfOthers;

/// <summary>
///     https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/
/// </summary>
public interface ILargestNumberAtLeastTwiceOfOthers
{
    /// <summary>
    ///     Determines whether the largest element of <paramref name="nums" /> is at least twice as large as every other
    ///     element.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The index of the largest element if it is at least twice as large as every other element; otherwise, -1.</returns>
    int DominantIndex(int[] nums);
}