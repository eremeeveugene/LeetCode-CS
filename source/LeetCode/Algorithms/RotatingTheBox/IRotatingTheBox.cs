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

namespace LeetCode.Algorithms.RotatingTheBox;

/// <summary>
///     https://leetcode.com/problems/rotating-the-box/description/
/// </summary>
public interface IRotatingTheBox
{
    /// <summary>
    ///     Rotates <paramref name="box" /> 90 degrees clockwise after letting gravity settle the stones ('#')
    ///     so that they fall to the lowest available position within each row, blocked by obstacles ('*').
    /// </summary>
    /// <param name="box">The grid representing the box, where '#' is a stone, '*' is an obstacle, and '.' is empty.</param>
    /// <returns>The grid after gravity is applied and the box is rotated 90 degrees clockwise.</returns>
    char[][] RotateTheBox(char[][] box);
}