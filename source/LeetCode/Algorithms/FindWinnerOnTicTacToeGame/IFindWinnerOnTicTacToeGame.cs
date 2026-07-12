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

namespace LeetCode.Algorithms.FindWinnerOnTicTacToeGame;

/// <summary>
///     https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/description/
/// </summary>
public interface IFindWinnerOnTicTacToeGame
{
    /// <summary>
    ///     Determines the outcome of a tic-tac-toe game after the sequence of <paramref name="moves" /> played alternately
    ///     by players A and B.
    /// </summary>
    /// <param name="moves">The sequence of moves, where each pair [row, column] is the cell played on that turn.</param>
    /// <returns>"A" or "B" if the corresponding player wins, "Draw" if the game ends in a draw, or "Pending" otherwise.</returns>
    string Tictactoe(int[][] moves);
}