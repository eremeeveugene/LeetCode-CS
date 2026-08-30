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

namespace LeetCode.Algorithms.PacificAtlanticWaterFlow;

/// <summary>
///     https://leetcode.com/problems/pacific-atlantic-water-flow/description/
/// </summary>
public interface IPacificAtlanticWaterFlow
{
    /// <summary>
    ///     Finds the coordinates from which rain water can flow to both the Pacific and Atlantic oceans.
    /// </summary>
    /// <param name="heights">The rectangular grid of cell heights.</param>
    /// <returns>The coordinates of cells that can reach both oceans.</returns>
    IList<IList<int>> PacificAtlantic(int[][] heights);
}