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

namespace LeetCode.Algorithms.PascalsTriangle2;

/// <summary>
///     https://leetcode.com/problems/pascals-triangle-ii/description/
/// </summary>
public interface IPascalsTriangle2
{
    /// <summary>
    ///     Returns the <paramref name="rowIndex" />-th row (0-indexed) of Pascal's triangle.
    /// </summary>
    /// <param name="rowIndex">The zero-based index of the row to return.</param>
    /// <returns>The requested row of Pascal's triangle.</returns>
    IList<int> GetRow(int rowIndex);
}