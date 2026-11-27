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

namespace LeetCode.Algorithms.CountDominantElements;

/// <summary>
///     https://leetcode.com/problems/count-dominant-elements/description/
/// </summary>
public interface ICountDominantElements
{
    /// <summary>
    ///     Counts the elements of <paramref name="nums" /> that are greater than or equal to the average of their existing
    ///     immediate neighbors, an element without neighbors being dominant.
    /// </summary>
    /// <param name="nums">The array of integers to scan for dominant elements.</param>
    /// <returns>The number of dominant elements in <paramref name="nums" />.</returns>
    int CountDominantElements(int[] nums);
}