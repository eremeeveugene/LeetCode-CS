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

namespace LeetCode.Algorithms.MakeASquareWithTheSameColor;

/// <summary>
///     https://leetcode.com/problems/make-a-square-with-the-same-color/description/
/// </summary>
public interface IMakeASquareWithTheSameColor
{
    /// <summary>
    ///     Determines whether changing the color of at most one cell of <paramref name="grid" /> can produce a 2 x 2
    ///     square where all cells have the same color.
    /// </summary>
    /// <param name="grid">The 3 x 3 matrix consisting only of the characters 'B' (black) and 'W' (white).</param>
    /// <returns><see langword="true" /> if such a 2 x 2 square can be created; otherwise, <see langword="false" />.</returns>
    bool CanMakeSquare(char[][] grid);
}