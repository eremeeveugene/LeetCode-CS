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

namespace LeetCode.Algorithms.FindChampion2;

/// <summary>
///     https://leetcode.com/problems/find-champion-ii/description/
/// </summary>
public interface IFindChampion2
{
    /// <summary>
    ///     Finds the unique team, among <paramref name="n" /> teams connected by the dominance relationships in
    ///     <paramref name="edges" />, that is stronger than all other teams.
    /// </summary>
    /// <param name="n">The number of teams, labeled from 0 to n - 1.</param>
    /// <param name="edges">The array of directed edges [a, b] indicating team a is stronger than team b.</param>
    /// <returns>The identifier of the champion team, or -1 if the champion cannot be uniquely determined.</returns>
    int FindChampion(int n, int[][] edges);
}