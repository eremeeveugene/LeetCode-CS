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

namespace LeetCode.Algorithms.SortTheMatrixDiagonally;

/// <summary>
///     https://leetcode.com/problems/sort-the-matrix-diagonally/description/
/// </summary>
public interface ISortTheMatrixDiagonally
{
    /// <summary>
    ///     Sorts each diagonal of <paramref name="mat" /> that runs from top-left to bottom-right in ascending
    ///     order.
    /// </summary>
    /// <param name="mat">The matrix whose diagonals are to be sorted.</param>
    /// <returns>The matrix <paramref name="mat" /> after each top-left to bottom-right diagonal has been sorted.</returns>
    int[][] DiagonalSort(int[][] mat);
}