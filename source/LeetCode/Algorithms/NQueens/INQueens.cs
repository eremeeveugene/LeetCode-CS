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

namespace LeetCode.Algorithms.NQueens;

/// <summary>
///     https://leetcode.com/problems/n-queens/description/
/// </summary>
public interface INQueens
{
    /// <summary>
    ///     Finds all distinct placements of <paramref name="n" /> queens on an <paramref name="n" /> x
    ///     <paramref name="n" /> chessboard such that no two queens attack each other.
    /// </summary>
    /// <param name="n">The size of the chessboard and the number of queens to place.</param>
    /// <returns>
    ///     All distinct board configurations, where each board is a list of rows and each row uses <c>'Q'</c> for a
    ///     queen and <c>'.'</c> for an empty square.
    /// </returns>
    IList<IList<string>> SolveNQueens(int n);
}