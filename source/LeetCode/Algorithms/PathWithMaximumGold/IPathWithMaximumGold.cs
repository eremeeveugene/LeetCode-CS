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

namespace LeetCode.Algorithms.PathWithMaximumGold;

/// <summary>
///     https://leetcode.com/problems/path-with-maximum-gold/description/
/// </summary>
public interface IPathWithMaximumGold
{
    /// <summary>
    ///     Finds the maximum amount of gold that can be collected by starting at any cell of <paramref name="grid" /> and
    ///     moving to adjacent cells without revisiting a cell or passing through a cell with no gold.
    /// </summary>
    /// <param name="grid">The grid where each cell contains the amount of gold at that position, or 0 if empty.</param>
    /// <returns>The maximum amount of gold that can be collected along a single path.</returns>
    int GetMaximumGold(int[][] grid);
}