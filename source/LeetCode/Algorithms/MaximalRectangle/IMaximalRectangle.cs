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

namespace LeetCode.Algorithms.MaximalRectangle;

/// <summary>
///     https://leetcode.com/problems/maximal-rectangle/
/// </summary>
public interface IMaximalRectangle
{
    /// <summary>
    ///     Finds the area of the largest rectangle containing only 1s within the binary matrix <paramref name="matrix" />.
    /// </summary>
    /// <param name="matrix">The binary matrix, represented as characters '0' and '1', to search for the largest rectangle.</param>
    /// <returns>The area of the largest rectangle containing only 1s in <paramref name="matrix" />.</returns>
    int MaximalRectangle(char[][] matrix);
}