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

namespace LeetCode.Algorithms.DiagonalTraverse;

/// <summary>
///     https://leetcode.com/problems/diagonal-traverse/description/
/// </summary>
public interface IDiagonalTraverse
{
    /// <summary>
    ///     Returns all elements of <paramref name="mat" /> in diagonal order, alternating the traversal direction on each
    ///     diagonal.
    /// </summary>
    /// <param name="mat">The matrix of integers.</param>
    /// <returns>An array containing all elements of the matrix in diagonal order.</returns>
    int[] FindDiagonalOrder(int[][] mat);
}