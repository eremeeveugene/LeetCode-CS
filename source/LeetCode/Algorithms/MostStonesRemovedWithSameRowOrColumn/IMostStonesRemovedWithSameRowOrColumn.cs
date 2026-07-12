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

namespace LeetCode.Algorithms.MostStonesRemovedWithSameRowOrColumn;

/// <summary>
///     https://leetcode.com/problems/most-stones-removed-with-same-row-or-column/description/
/// </summary>
public interface IMostStonesRemovedWithSameRowOrColumn
{
    /// <summary>
    ///     Determines the maximum number of stones in <paramref name="stones" /> that can be removed, where a stone
    ///     can be removed if another remaining stone shares the same row or column.
    /// </summary>
    /// <param name="stones">The list of stone positions, each represented as a [row, column] pair.</param>
    /// <returns>The maximum number of stones that can be removed.</returns>
    int RemoveStones(int[][] stones);
}