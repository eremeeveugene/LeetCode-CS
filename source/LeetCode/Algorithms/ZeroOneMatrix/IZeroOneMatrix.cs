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

namespace LeetCode.Algorithms.ZeroOneMatrix;

/// <summary>
///     https://leetcode.com/problems/01-matrix/description/
/// </summary>
public interface IZeroOneMatrix
{
    /// <summary>
    ///     Computes, for every cell of <paramref name="mat" />, the distance to the nearest cell containing
    ///     <c>0</c>, where the distance between two cells sharing a common edge is <c>1</c>.
    /// </summary>
    /// <param name="mat">An <c>m x n</c> binary matrix where each cell is either <c>0</c> or <c>1</c>.</param>
    /// <returns>An <c>m x n</c> matrix where each cell holds its distance to the nearest <c>0</c>.</returns>
    int[][] UpdateMatrix(int[][] mat);
}