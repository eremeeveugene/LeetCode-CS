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

namespace LeetCode.Algorithms.CheckIfItIsStraightLine;

/// <summary>
///     https://leetcode.com/problems/check-if-it-is-a-straight-line/description/
/// </summary>
public interface ICheckIfItIsStraightLine
{
    /// <summary>
    ///     Determines whether all points in <paramref name="coordinates" /> lie on a single straight line.
    /// </summary>
    /// <param name="coordinates">The points given as [x, y] coordinates.</param>
    /// <returns><c>true</c> if all points lie on a single straight line; otherwise, <c>false</c>.</returns>
    bool CheckStraightLine(int[][] coordinates);
}