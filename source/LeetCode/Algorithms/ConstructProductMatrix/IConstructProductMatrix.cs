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

namespace LeetCode.Algorithms.ConstructProductMatrix;

/// <summary>
///     https://leetcode.com/problems/construct-product-matrix/description/
/// </summary>
public interface IConstructProductMatrix
{
    /// <summary>
    ///     Constructs the product matrix of <paramref name="grid" />, where each element is the product of all elements of
    ///     <paramref name="grid" /> except the one at the same position, taken modulo 12345.
    /// </summary>
    /// <param name="grid">The matrix of integers.</param>
    /// <returns>The product matrix of <paramref name="grid" /> with each element taken modulo 12345.</returns>
    int[][] ConstructProductMatrix(int[][] grid);
}