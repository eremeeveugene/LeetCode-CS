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

namespace LeetCode.Algorithms.Search2DMatrix;

/// <summary>
///     https://leetcode.com/problems/search-a-2d-matrix/description/
/// </summary>
public interface ISearch2DMatrix
{
    /// <summary>
    ///     Determines whether <paramref name="target" /> exists in <paramref name="matrix" />, where each row is sorted in
    ///     ascending order and the first integer of each row is greater than the last integer of the previous row.
    /// </summary>
    /// <param name="matrix">The <c>m x n</c> matrix of integers.</param>
    /// <param name="target">The integer value to search for.</param>
    /// <returns><c>true</c> if <paramref name="target" /> exists in <paramref name="matrix" />; otherwise, <c>false</c>.</returns>
    bool SearchMatrix(int[][] matrix, int target);
}