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

namespace LeetCode.Algorithms.RangeAddition2;

/// <summary>
///     https://leetcode.com/problems/range-addition-ii/description/
/// </summary>
public interface IRangeAddition2
{
    /// <summary>
    ///     Counts the number of cells holding the maximum value in an <paramref name="m" /> by <paramref name="n" /> grid
    ///     after applying every increment operation in <paramref name="ops" />.
    /// </summary>
    /// <param name="m">The number of rows in the grid.</param>
    /// <param name="n">The number of columns in the grid.</param>
    /// <param name="ops">The list of operations, each defining the top-left submatrix to increment by one.</param>
    /// <returns>The count of cells that hold the maximum integer in the grid after all operations.</returns>
    int MaxCount(int m, int n, int[][] ops);
}