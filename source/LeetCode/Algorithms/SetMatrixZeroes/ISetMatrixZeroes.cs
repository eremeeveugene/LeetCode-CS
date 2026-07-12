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

namespace LeetCode.Algorithms.SetMatrixZeroes;

/// <summary>
///     https://leetcode.com/problems/set-matrix-zeroes/description/
/// </summary>
public interface ISetMatrixZeroes
{
    /// <summary>
    ///     Sets the entire row and column of <paramref name="matrix" /> to 0 for every cell that originally
    ///     contains 0, modifying the matrix in place.
    /// </summary>
    /// <param name="matrix">The matrix to modify in place.</param>
    void SetZeroes(int[][] matrix);
}