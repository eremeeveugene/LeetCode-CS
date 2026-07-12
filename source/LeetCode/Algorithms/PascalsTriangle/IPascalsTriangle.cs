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

namespace LeetCode.Algorithms.PascalsTriangle;

/// <summary>
///     https://leetcode.com/problems/pascals-triangle/
/// </summary>
public interface IPascalsTriangle
{
    /// <summary>
    ///     Generates the first <paramref name="numRows" /> rows of Pascal's triangle.
    /// </summary>
    /// <param name="numRows">The number of rows to generate.</param>
    /// <returns>A list containing the requested rows of Pascal's triangle.</returns>
    IList<IList<int>> Generate(int numRows);
}