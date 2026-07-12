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

namespace LeetCode.Algorithms.FlipColumnsForMaximumNumberOfEqualRows;

/// <summary>
///     https://leetcode.com/problems/flip-columns-for-maximum-number-of-equal-rows/description/
/// </summary>
public interface IFlipColumnsForMaximumNumberOfEqualRows
{
    /// <summary>
    ///     Finds the maximum number of rows of <paramref name="matrix" /> that can be made entirely equal (all 0s or all
    ///     1s) by flipping any subset of columns.
    /// </summary>
    /// <param name="matrix">The binary matrix.</param>
    /// <returns>The maximum number of rows with all values equal after some column flips.</returns>
    int MaxEqualRowsAfterFlips(int[][] matrix);
}