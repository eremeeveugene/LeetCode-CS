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

namespace LeetCode.Algorithms.IncrementSubmatricesByOne;

/// <summary>
///     https://leetcode.com/problems/increment-submatrices-by-one/description/
/// </summary>
public interface IIncrementSubmatricesByOne
{
    /// <summary>
    ///     Starting from an n x n matrix filled with zeroes, for each query [row1, col1, row2, col2] adds 1 to every element
    ///     in the submatrix with the top left corner (row1, col1) and the bottom right corner (row2, col2).
    /// </summary>
    /// <param name="n">The size of the matrix.</param>
    /// <param name="queries">The array of queries, where each query is a quadruple [row1, col1, row2, col2] of submatrix bounds.</param>
    /// <returns>The matrix after performing every query.</returns>
    int[][] RangeAddQueries(int n, int[][] queries);
}