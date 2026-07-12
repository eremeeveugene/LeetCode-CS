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

namespace LeetCode.Algorithms.SpecialPositionsInBinaryMatrix;

/// <summary>
///     https://leetcode.com/problems/special-positions-in-a-binary-matrix/description/
/// </summary>
public interface ISpecialPositionsInBinaryMatrix
{
    /// <summary>
    ///     Counts the special positions in <paramref name="mat" />, where a position (i, j) is special if
    ///     mat[i][j] == 1 and every other element in row i and column j is 0.
    /// </summary>
    /// <param name="mat">The binary matrix to search.</param>
    /// <returns>The number of special positions in <paramref name="mat" />.</returns>
    int NumSpecial(int[][] mat);
}