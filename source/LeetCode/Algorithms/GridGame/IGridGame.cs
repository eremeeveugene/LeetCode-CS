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

namespace LeetCode.Algorithms.GridGame;

/// <summary>
///     https://leetcode.com/problems/grid-game/description/
/// </summary>
public interface IGridGame
{
    /// <summary>
    ///     Determines the number of points the second robot can collect in the 2 x n matrix
    ///     <paramref name="grid" /> when the first robot moves optimally to minimize that amount and both robots play
    ///     optimally.
    /// </summary>
    /// <param name="grid">The 2 x n matrix of points.</param>
    /// <returns>The number of points collected by the second robot when both robots play optimally.</returns>
    long GridGame(int[][] grid);
}