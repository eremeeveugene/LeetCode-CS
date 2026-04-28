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

namespace LeetCode.Algorithms.CheckIfThereIsValidPathInGrid;

/// <summary>
///     https://leetcode.com/problems/check-if-there-is-a-valid-path-in-a-grid/description/
/// </summary>
public interface ICheckIfThereIsValidPathInGrid
{
    /// <summary>
    ///     Determines whether there is a valid path from the top-left cell to the bottom-right cell.
    /// </summary>
    /// <param name="grid">
    ///     A 2D integer array where each value represents a street type and its allowed connections.
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if a valid path exists; otherwise, <see langword="false" />.
    /// </returns>
    bool HasValidPath(int[][] grid);
}