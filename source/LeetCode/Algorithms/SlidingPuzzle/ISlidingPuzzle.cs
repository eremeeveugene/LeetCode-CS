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

namespace LeetCode.Algorithms.SlidingPuzzle;

/// <summary>
///     https://leetcode.com/problems/sliding-puzzle/description/
/// </summary>
public interface ISlidingPuzzle
{
    /// <summary>
    ///     Computes the minimum number of moves needed to transform the 2x3 <paramref name="board" /> into the
    ///     solved state [[1,2,3],[4,5,0]] by repeatedly swapping the empty cell (0) with an adjacent tile.
    /// </summary>
    /// <param name="board">The 2x3 board representing the current tile arrangement, where 0 is the empty cell.</param>
    /// <returns>The minimum number of moves to solve the puzzle, or -1 if it cannot be solved.</returns>
    int SlidingPuzzle(int[][] board);
}