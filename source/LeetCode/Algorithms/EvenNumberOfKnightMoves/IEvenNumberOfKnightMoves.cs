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

namespace LeetCode.Algorithms.EvenNumberOfKnightMoves;

/// <summary>
///     https://leetcode.com/problems/even-number-of-knight-moves/description/
/// </summary>
public interface IEvenNumberOfKnightMoves
{
    /// <summary>
    ///     Determines whether a knight can reach the target in an even number of moves on an 8 x 8 chessboard.
    /// </summary>
    /// <param name="start">The starting cell as [x, y], with each coordinate between 0 and 7.</param>
    /// <param name="target">The target cell as [x, y], with each coordinate between 0 and 7.</param>
    /// <returns><c>true</c> if the target is reachable in an even number of moves; otherwise, <c>false</c>.</returns>
    bool CanReach(int[] start, int[] target);
}