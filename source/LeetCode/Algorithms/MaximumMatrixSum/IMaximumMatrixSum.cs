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

namespace LeetCode.Algorithms.MaximumMatrixSum;

/// <summary>
///     https://leetcode.com/problems/maximum-matrix-sum/description/
/// </summary>
public interface IMaximumMatrixSum
{
    /// <summary>
    ///     Computes the maximum possible sum of elements of <paramref name="matrix" /> obtainable by repeatedly negating
    ///     any two elements (any number of times).
    /// </summary>
    /// <param name="matrix">The square matrix of integers to transform via pairwise negations.</param>
    /// <returns>The maximum possible sum of all elements of <paramref name="matrix" /> after any number of pairwise negations.</returns>
    long MaxMatrixSum(int[][] matrix);
}