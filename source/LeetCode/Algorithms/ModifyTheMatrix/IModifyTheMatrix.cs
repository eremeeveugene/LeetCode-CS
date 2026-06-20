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

namespace LeetCode.Algorithms.ModifyTheMatrix;

/// <summary>
///     https://leetcode.com/problems/modify-the-matrix/
/// </summary>
public interface IModifyTheMatrix
{
    /// <summary>
    ///     Builds a new matrix equal to <paramref name="matrix" /> in which every element equal to <c>-1</c> is replaced with
    ///     the maximum element of its respective column. Each column is guaranteed to contain at least one non-negative
    ///     integer.
    /// </summary>
    /// <param name="matrix">The <c>m x n</c> matrix to modify.</param>
    /// <returns>The modified matrix where each <c>-1</c> is replaced with the maximum element of its column.</returns>
    int[][] ModifiedMatrix(int[][] matrix);
}