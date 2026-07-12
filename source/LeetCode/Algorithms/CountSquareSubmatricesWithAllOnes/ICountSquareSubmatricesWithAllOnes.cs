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

namespace LeetCode.Algorithms.CountSquareSubmatricesWithAllOnes;

/// <summary>
///     https://leetcode.com/problems/count-square-submatrices-with-all-ones/description/
/// </summary>
public interface ICountSquareSubmatricesWithAllOnes
{
    /// <summary>
    ///     Counts the square submatrices of <paramref name="matrix" /> that consist entirely of ones.
    /// </summary>
    /// <param name="matrix">The binary matrix to examine.</param>
    /// <returns>The number of square submatrices with all ones.</returns>
    int CountSquares(int[][] matrix);
}