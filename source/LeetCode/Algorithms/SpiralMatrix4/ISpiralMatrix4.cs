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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.SpiralMatrix4;

/// <summary>
///     https://leetcode.com/problems/spiral-matrix-iv/description/
/// </summary>
public interface ISpiralMatrix4
{
    /// <summary>
    ///     Fills an <paramref name="m" /> by <paramref name="n" /> matrix in clockwise spiral order with the
    ///     values from the linked list starting at <paramref name="head" />, filling any remaining cells with
    ///     -1.
    /// </summary>
    /// <param name="m">The number of rows in the matrix.</param>
    /// <param name="n">The number of columns in the matrix.</param>
    /// <param name="head">The head of the linked list whose values populate the matrix.</param>
    /// <returns>The <paramref name="m" /> by <paramref name="n" /> matrix filled in spiral order with the list's values.</returns>
    int[][] SpiralMatrix(int m, int n, ListNode head);
}