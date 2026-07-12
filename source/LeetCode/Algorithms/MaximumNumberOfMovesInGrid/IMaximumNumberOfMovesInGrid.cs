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

namespace LeetCode.Algorithms.MaximumNumberOfMovesInGrid;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-moves-in-a-grid/description/
/// </summary>
public interface IMaximumNumberOfMovesInGrid
{
    /// <summary>
    ///     Starting from any cell in the first column of <paramref name="grid" />, computes the maximum number of moves
    ///     achievable by repeatedly moving to an adjacent cell in the next column (up-right, right, or down-right) whose
    ///     value is strictly greater than the current cell's value.
    /// </summary>
    /// <param name="grid">The grid of integers to traverse column by column.</param>
    /// <returns>The maximum number of moves that can be made across <paramref name="grid" />.</returns>
    int MaxMoves(int[][] grid);
}