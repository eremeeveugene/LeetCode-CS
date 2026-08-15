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

namespace LeetCode.Algorithms.AvailableCapturesForRook;

/// <summary>
///     https://leetcode.com/problems/available-captures-for-rook/description/
/// </summary>
public interface IAvailableCapturesForRook
{
    /// <summary>
    ///     Determines the number of pawns the white rook is attacking on the given chessboard.
    /// </summary>
    /// <param name="board">
    ///     An 8 x 8 matrix representing the chessboard, containing exactly one <c>'R'</c> (rook), any number of
    ///     <c>'B'</c> (bishops) and <c>'p'</c> (pawns), and <c>'.'</c> for empty squares.
    /// </param>
    /// <returns>The number of pawns the rook is attacking.</returns>
    int NumRookCaptures(char[][] board);
}