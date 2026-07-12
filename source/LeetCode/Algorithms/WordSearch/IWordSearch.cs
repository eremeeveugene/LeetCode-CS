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

namespace LeetCode.Algorithms.WordSearch;

/// <summary>
///     https://leetcode.com/problems/word-search/
/// </summary>
public interface IWordSearch
{
    /// <summary>
    ///     Determines whether <paramref name="word" /> can be constructed from letters of sequentially adjacent
    ///     cells in <paramref name="board" />, using each cell at most once.
    /// </summary>
    /// <param name="board">The grid of characters to search within.</param>
    /// <param name="word">The word to search for in the grid.</param>
    /// <returns><see langword="true" /> if <paramref name="word" /> exists in the grid; otherwise, <see langword="false" />.</returns>
    bool Exist(char[][] board, string word);
}