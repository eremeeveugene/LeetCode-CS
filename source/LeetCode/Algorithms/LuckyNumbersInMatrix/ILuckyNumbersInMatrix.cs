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

namespace LeetCode.Algorithms.LuckyNumbersInMatrix;

/// <summary>
///     https://leetcode.com/problems/lucky-numbers-in-a-matrix/description/
/// </summary>
public interface ILuckyNumbersInMatrix
{
    /// <summary>
    ///     Finds all lucky numbers in <paramref name="matrix" />, where a lucky number is the minimum element in its
    ///     row and the maximum element in its column.
    /// </summary>
    /// <param name="matrix">The matrix of distinct integers to search for lucky numbers.</param>
    /// <returns>A list of all lucky numbers found in <paramref name="matrix" />.</returns>
    IList<int> LuckyNumbers(int[][] matrix);
}