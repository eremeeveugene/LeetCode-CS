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

namespace LeetCode.Algorithms.SwimInRisingWater;

/// <summary>
///     https://leetcode.com/problems/swim-in-rising-water/description/
/// </summary>
public interface ISwimInRisingWater
{
    /// <summary>
    ///     Finds the minimum time at which it becomes possible to swim from the top-left cell to the bottom-right
    ///     cell of <paramref name="grid" />, where the water level at time <c>t</c> allows travel only through
    ///     cells with an elevation of at most <c>t</c>.
    /// </summary>
    /// <param name="grid">The square grid where each cell holds the elevation at that position.</param>
    /// <returns>The minimum time required to reach the bottom-right cell from the top-left cell.</returns>
    int SwimInWater(int[][] grid);
}