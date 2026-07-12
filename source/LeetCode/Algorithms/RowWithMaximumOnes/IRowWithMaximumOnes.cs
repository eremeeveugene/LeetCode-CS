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

namespace LeetCode.Algorithms.RowWithMaximumOnes;

/// <summary>
///     https://leetcode.com/problems/row-with-maximum-ones/description/
/// </summary>
public interface IRowWithMaximumOnes
{
    /// <summary>
    ///     Finds the row in <paramref name="mat" /> that contains the maximum number of ones.
    /// </summary>
    /// <param name="mat">The binary matrix to search.</param>
    /// <returns>An array containing the index of the row with the most ones and the count of ones in that row.</returns>
    int[] RowAndMaximumOnes(int[][] mat);
}