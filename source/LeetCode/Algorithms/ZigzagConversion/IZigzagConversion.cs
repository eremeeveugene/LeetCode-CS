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

namespace LeetCode.Algorithms.ZigzagConversion;

/// <summary>
///     https://leetcode.com/problems/zigzag-conversion/description/
/// </summary>
public interface IZigzagConversion
{
    /// <summary>
    ///     Arranges the characters of <paramref name="s" /> in a zigzag pattern across
    ///     <paramref name="numRows" /> rows and reads them back row by row.
    /// </summary>
    /// <param name="s">The string to rearrange into the zigzag pattern.</param>
    /// <param name="numRows">The number of rows in the zigzag pattern.</param>
    /// <returns>The string read line by line after the zigzag arrangement.</returns>
    string Convert(string s, int numRows);
}