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

namespace LeetCode.Algorithms.FindValidMatrixGivenRowAndColumnSums;

/// <summary>
///     https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums/description/
/// </summary>
public interface IFindValidMatrixGivenRowAndColumnSums
{
    /// <summary>
    ///     Restores a matrix of non-negative integers whose row sums equal <paramref name="rowSum" /> and whose column
    ///     sums equal <paramref name="colSum" />.
    /// </summary>
    /// <param name="rowSum">The required sum of each row of the matrix.</param>
    /// <param name="colSum">The required sum of each column of the matrix.</param>
    /// <returns>A matrix of non-negative integers satisfying the given row and column sums.</returns>
    int[][] RestoreMatrix(int[] rowSum, int[] colSum);
}