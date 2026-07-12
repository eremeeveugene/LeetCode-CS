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

namespace LeetCode.Algorithms.CheckIfGridCanBeCutIntoSections;

/// <summary>
///     https://leetcode.com/problems/check-if-grid-can-be-cut-into-sections/description/
/// </summary>
public interface ICheckIfGridCanBeCutIntoSections
{
    /// <summary>
    ///     Determines whether an <paramref name="n" /> x <paramref name="n" /> grid can be cut by two horizontal or two
    ///     vertical lines into three sections such that each of the <paramref name="rectangles" /> lies entirely within one
    ///     section and every section contains at least one rectangle.
    /// </summary>
    /// <param name="n">The size of the grid.</param>
    /// <param name="rectangles">The rectangles given as [startX, startY, endX, endY] coordinates.</param>
    /// <returns><c>true</c> if two such valid cuts can be made; otherwise, <c>false</c>.</returns>
    bool CheckValidCuts(int n, int[][] rectangles);
}