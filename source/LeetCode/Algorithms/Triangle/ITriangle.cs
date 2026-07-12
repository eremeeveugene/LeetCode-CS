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

namespace LeetCode.Algorithms.Triangle;

/// <summary>
///     https://leetcode.com/problems/triangle/description/
/// </summary>
public interface ITriangle
{
    /// <summary>
    ///     Finds the minimum path sum from the top to the bottom of <paramref name="triangle" />, where each step
    ///     may move to an adjacent number on the row below.
    /// </summary>
    /// <param name="triangle">The triangle of numbers represented as a list of rows.</param>
    /// <returns>The minimum possible sum of a path from the top to the bottom of the triangle.</returns>
    int MinimumTotal(IList<IList<int>> triangle);
}