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

namespace LeetCode.Algorithms.MagicSquaresInGrid;

/// <summary>
///     https://leetcode.com/problems/magic-squares-in-grid/
/// </summary>
public interface IMagicSquaresInGrid
{
    /// <summary>
    ///     Counts the number of 3 x 3 magic square subgrids contained within <paramref name="grid" />.
    /// </summary>
    /// <param name="grid">The grid of integers to search for magic squares.</param>
    /// <returns>The number of 3 x 3 magic squares found inside <paramref name="grid" />.</returns>
    int NumMagicSquaresInside(int[][] grid);
}