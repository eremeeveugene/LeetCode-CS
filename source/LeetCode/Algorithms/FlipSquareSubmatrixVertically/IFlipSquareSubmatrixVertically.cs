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

namespace LeetCode.Algorithms.FlipSquareSubmatrixVertically;

/// <summary>
///     https://leetcode.com/problems/flip-square-submatrix-vertically/description/
/// </summary>
public interface IFlipSquareSubmatrixVertically
{
    /// <summary>
    ///     Flips vertically the k x k square submatrix of <paramref name="grid" /> whose top-left corner is at row
    ///     <paramref name="x" /> and column <paramref name="y" />.
    /// </summary>
    /// <param name="grid">The matrix of integers.</param>
    /// <param name="x">The row index of the top-left corner of the submatrix.</param>
    /// <param name="y">The column index of the top-left corner of the submatrix.</param>
    /// <param name="k">The size of the square submatrix.</param>
    /// <returns>The matrix after flipping the specified submatrix vertically.</returns>
    int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k);
}