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

namespace LeetCode.Algorithms.ValidSudoku;

/// <summary>
///     https://leetcode.com/problems/valid-sudoku/description/
/// </summary>
public interface IValidSudoku
{
    /// <summary>
    ///     Determines whether the partially filled 9x9 Sudoku <paramref name="board" /> is valid — no repeated
    ///     digit within any row, column, or 3x3 sub-box.
    /// </summary>
    /// <param name="board">The 9x9 Sudoku board, with empty cells represented by <c>'.'</c>.</param>
    /// <returns><see langword="true" /> if the board is valid; otherwise, <see langword="false" />.</returns>
    bool IsValidSudoku(char[][] board);
}