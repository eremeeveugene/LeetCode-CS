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

namespace LeetCode.Algorithms.MinimumQueenMovesToReachTarget;

/// <summary>
///     https://leetcode.com/problems/minimum-queen-moves-to-reach-target/description/
/// </summary>
public interface IMinimumQueenMovesToReachTarget
{
    /// <summary>
    ///     Finds the minimum number of queen moves needed to travel between two cells of an empty 8 x 8 chessboard.
    /// </summary>
    /// <param name="source">The starting cell as [row, column], with each coordinate between 1 and 8.</param>
    /// <param name="target">The target cell as [row, column], with each coordinate between 1 and 8.</param>
    /// <returns>The minimum number of moves for the queen to land exactly on the target.</returns>
    int MinQueenMoves(int[] source, int[] target);
}