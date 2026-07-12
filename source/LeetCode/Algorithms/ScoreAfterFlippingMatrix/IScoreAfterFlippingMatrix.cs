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

namespace LeetCode.Algorithms.ScoreAfterFlippingMatrix;

/// <summary>
///     https://leetcode.com/problems/score-after-flipping-matrix/description/
/// </summary>
public interface IScoreAfterFlippingMatrix
{
    /// <summary>
    ///     Toggles any rows and columns of <paramref name="grid" /> (interpreted as binary numbers per row)
    ///     to maximize the total score, where score is the sum of the binary numbers formed by each row.
    /// </summary>
    /// <param name="grid">The binary matrix to optimize.</param>
    /// <returns>The highest possible score achievable after toggling rows and columns of <paramref name="grid" />.</returns>
    int MatrixScore(int[][] grid);
}