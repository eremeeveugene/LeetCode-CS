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

namespace LeetCode.Algorithms.CountSubIslands;

/// <summary>
///     https://leetcode.com/problems/count-sub-islands/description/
/// </summary>
public interface ICountSubIslands
{
    /// <summary>
    ///     Counts the islands in <paramref name="grid2" /> that are sub-islands, meaning every cell of the island is
    ///     also part of an island in <paramref name="grid1" />.
    /// </summary>
    /// <param name="grid1">The first binary matrix.</param>
    /// <param name="grid2">The second binary matrix whose islands are checked.</param>
    /// <returns>The number of islands in <paramref name="grid2" /> that are sub-islands of <paramref name="grid1" />.</returns>
    int CountSubIslands(int[][] grid1, int[][] grid2);
}