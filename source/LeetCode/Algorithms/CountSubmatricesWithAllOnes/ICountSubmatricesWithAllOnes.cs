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

namespace LeetCode.Algorithms.CountSubmatricesWithAllOnes;

/// <summary>
///     https://leetcode.com/problems/count-submatrices-with-all-ones/description/
/// </summary>
public interface ICountSubmatricesWithAllOnes
{
    /// <summary>
    ///     Counts the submatrices of <paramref name="mat" /> that consist entirely of ones.
    /// </summary>
    /// <param name="mat">The binary matrix to examine.</param>
    /// <returns>The number of submatrices with all ones.</returns>
    int NumSubmat(int[][] mat);
}