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

namespace LeetCode.Algorithms.MatrixDiagonalSum;

/// <summary>
///     https://leetcode.com/problems/matrix-diagonal-sum/description/
/// </summary>
public interface IMatrixDiagonalSum
{
    /// <summary>
    ///     Computes the sum of the elements on both diagonals of the square matrix <paramref name="mat" />, counting the
    ///     middle element only once when the matrix has an odd size.
    /// </summary>
    /// <param name="mat">The square matrix whose diagonal elements are summed.</param>
    /// <returns>The sum of the primary and secondary diagonal elements of <paramref name="mat" />.</returns>
    int DiagonalSum(int[][] mat);
}