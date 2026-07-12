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

namespace LeetCode.Algorithms.RegionsCutBySlashes;

/// <summary>
///     https://leetcode.com/problems/regions-cut-by-slashes/description/
/// </summary>
public interface IRegionsCutBySlashes
{
    /// <summary>
    ///     Counts the number of regions formed by the slashes, backslashes, and blank spaces described in
    ///     <paramref name="grid" />.
    /// </summary>
    /// <param name="grid">The grid of characters ('/', '\', or ' ') describing how each cell is cut.</param>
    /// <returns>The number of distinct regions the grid is divided into.</returns>
    int RegionsBySlashes(string[] grid);
}