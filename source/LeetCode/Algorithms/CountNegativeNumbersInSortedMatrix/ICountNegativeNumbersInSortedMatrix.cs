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

namespace LeetCode.Algorithms.CountNegativeNumbersInSortedMatrix;

/// <summary>
///     https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/description/
/// </summary>
public interface ICountNegativeNumbersInSortedMatrix
{
    /// <summary>
    ///     Counts the negative numbers in <paramref name="grid" />, a matrix sorted in non-increasing order both row-wise
    ///     and column-wise.
    /// </summary>
    /// <param name="grid">The matrix of integers sorted in non-increasing order by rows and columns.</param>
    /// <returns>The number of negative numbers in the matrix.</returns>
    int CountNegatives(int[][] grid);
}