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

namespace LeetCode.Algorithms.CountSubmatricesWithTopLeftElementAndSumLessThanK;

/// <summary>
///     https://leetcode.com/problems/count-submatrices-with-top-left-element-and-sum-less-than-k/description/
/// </summary>
public interface ICountSubmatricesWithTopLeftElementAndSumLessThanK
{
    /// <summary>
    ///     Counts the submatrices of <paramref name="grid" /> that contain the top-left element of the grid and have a sum
    ///     less than or equal to <paramref name="k" />.
    /// </summary>
    /// <param name="grid">The matrix of integers.</param>
    /// <param name="k">The maximum allowed submatrix sum.</param>
    /// <returns>The number of submatrices containing the top-left element whose sum is less than or equal to <paramref name="k" />.</returns>
    int CountSubmatrices(int[][] grid, int k);
}