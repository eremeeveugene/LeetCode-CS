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

namespace LeetCode.Algorithms.LargestLocalValuesInMatrix;

/// <summary>
///     https://leetcode.com/problems/largest-local-values-in-a-matrix/description/
/// </summary>
public interface ILargestLocalValuesInMatrix
{
    /// <summary>
    ///     Generates a matrix where each element is the largest value in the corresponding 3 x 3 submatrix of
    ///     <paramref name="grid" />.
    /// </summary>
    /// <param name="grid">The n x n matrix of integers.</param>
    /// <returns>The (n - 2) x (n - 2) matrix of the largest local values.</returns>
    int[][] LargestLocal(int[][] grid);
}