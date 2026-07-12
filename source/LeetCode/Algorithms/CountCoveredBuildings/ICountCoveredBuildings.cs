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

namespace LeetCode.Algorithms.CountCoveredBuildings;

/// <summary>
///     https://leetcode.com/problems/count-covered-buildings/description/
/// </summary>
public interface ICountCoveredBuildings
{
    /// <summary>
    ///     Counts the buildings that are covered, i.e. have at least one other building in each of the four directions
    ///     (left, right, above and below) on the <paramref name="n" /> x <paramref name="n" /> grid.
    /// </summary>
    /// <param name="n">The size of the grid.</param>
    /// <param name="buildings">The coordinates of the buildings, where each element is a pair [x, y].</param>
    /// <returns>The number of covered buildings.</returns>
    int CountCoveredBuildings(int n, int[][] buildings);
}