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

namespace LeetCode.Algorithms.MapOfHighestPeak;

/// <summary>
///     https://leetcode.com/problems/map-of-highest-peak/description/
/// </summary>
public interface IMapOfHighestPeak
{
    /// <summary>
    ///     Assigns a non-negative height to each cell of <paramref name="isWater" /> such that water cells
    ///     (<c>isWater[i][j] == 1</c>) get height <c>0</c>, adjacent cells (north/east/south/west) differ
    ///     in height by at most <c>1</c>, and the overall maximum height in the resulting grid is maximized.
    /// </summary>
    /// <param name="isWater">An <c>m x n</c> binary matrix where <c>1</c> marks water and <c>0</c> marks land.</param>
    /// <returns>An <c>m x n</c> matrix of assigned heights satisfying the constraints with the maximum possible peak.</returns>
    int[][] HighestPeak(int[][] isWater);
}