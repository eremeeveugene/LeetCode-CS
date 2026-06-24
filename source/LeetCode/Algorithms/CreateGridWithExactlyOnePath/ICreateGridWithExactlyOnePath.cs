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

namespace LeetCode.Algorithms.CreateGridWithExactlyOnePath;

/// <summary>
///     https://leetcode.com/problems/create-grid-with-exactly-one-path/description/
/// </summary>
public interface ICreateGridWithExactlyOnePath
{
    /// <summary>
    ///     Builds an <c>m x n</c> grid of free cells (<c>'.'</c>) and obstacles (<c>'#'</c>) that contains exactly one valid
    ///     path from the top-left cell <c>(0, 0)</c> to the bottom-right cell <c>(m - 1, n - 1)</c>, where every move travels
    ///     only right or down across free cells.
    /// </summary>
    /// <param name="m">The number of rows in the grid, with <c>1 &lt;= m &lt;= 25</c>.</param>
    /// <param name="n">The number of columns in the grid, with <c>1 &lt;= n &lt;= 25</c>.</param>
    /// <returns>
    ///     A grid represented as an array of <paramref name="m" /> strings, each of length <paramref name="n" />, that admits
    ///     exactly one valid path.
    /// </returns>
    string[] CreateGrid(int m, int n);
}