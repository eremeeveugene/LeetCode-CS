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

namespace LeetCode.Algorithms.TwistedMirrorPathCount;

/// <summary>
///     https://leetcode.com/problems/twisted-mirror-path-count/description/
/// </summary>
public interface ITwistedMirrorPathCount
{
    /// <summary>
    ///     Counts the valid paths of a robot from the top-left cell <c>(0, 0)</c> to the bottom-right cell
    ///     <c>(m - 1, n - 1)</c> of <paramref name="grid" />, where each move travels only right or down, and an attempt to
    ///     move right into a mirror turns the robot down, while an attempt to move down into a mirror turns it right.
    /// </summary>
    /// <param name="grid">
    ///     An <c>m x n</c> binary grid, with <c>2 &lt;= m, n &lt;= 500</c>, where <c>0</c> is an empty cell and <c>1</c> is
    ///     a mirror, and both corner cells are empty.
    /// </param>
    /// <returns>The number of valid paths modulo <c>10^9 + 7</c>.</returns>
    int UniquePaths(int[][] grid);
}