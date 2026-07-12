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

namespace LeetCode.Algorithms.ZigzagGridTraversalWithSkip;

/// <summary>
///     https://leetcode.com/problems/zigzag-grid-traversal-with-skip/description/
/// </summary>
public interface IZigzagGridTraversalWithSkip
{
    /// <summary>
    ///     Traverses <paramref name="grid" /> row by row in alternating left-to-right and right-to-left order,
    ///     collecting every other visited cell.
    /// </summary>
    /// <param name="grid">The 2D grid of integers to traverse.</param>
    /// <returns>A list of the collected values in zigzag traversal order.</returns>
    IList<int> ZigzagTraversal(int[][] grid);
}