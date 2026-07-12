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

namespace LeetCode.Algorithms.FindTheSafestPathInGrid;

/// <summary>
///     https://leetcode.com/problems/find-the-safest-path-in-a-grid/
/// </summary>
public interface IFindTheSafestPathInGrid
{
    /// <summary>
    ///     Finds the maximum safeness factor of a path from the top-left cell to the bottom-right cell of
    ///     <paramref name="grid" />, where the safeness factor is the minimum Manhattan distance from any cell on the path
    ///     to any thief.
    /// </summary>
    /// <param name="grid">The matrix where a value of 1 marks a cell containing a thief and 0 marks an empty cell.</param>
    /// <returns>The maximum safeness factor of all paths from the top-left cell to the bottom-right cell.</returns>
    int MaximumSafenessFactor(IList<IList<int>> grid);
}