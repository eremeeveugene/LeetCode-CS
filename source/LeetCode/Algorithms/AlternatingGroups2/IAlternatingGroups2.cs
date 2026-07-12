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

namespace LeetCode.Algorithms.AlternatingGroups2;

/// <summary>
///     https://leetcode.com/problems/alternating-groups-ii/description/
/// </summary>
public interface IAlternatingGroups2
{
    /// <summary>
    ///     Counts the alternating groups of <paramref name="k" /> contiguous tiles in the circular arrangement of
    ///     <paramref name="colors" /> where the tile colors alternate.
    /// </summary>
    /// <param name="colors">The colors of the tiles arranged in a circle, where 0 is red and 1 is blue.</param>
    /// <param name="k">The number of contiguous tiles in each group.</param>
    /// <returns>The number of alternating groups of <paramref name="k" /> contiguous tiles.</returns>
    int NumberOfAlternatingGroups(int[] colors, int k);
}