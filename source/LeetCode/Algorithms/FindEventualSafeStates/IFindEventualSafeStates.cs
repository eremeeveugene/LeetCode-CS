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

namespace LeetCode.Algorithms.FindEventualSafeStates;

/// <summary>
///     https://leetcode.com/problems/find-eventual-safe-states/description/
/// </summary>
public interface IFindEventualSafeStates
{
    /// <summary>
    ///     Finds all safe nodes of the directed graph <paramref name="graph" />, meaning nodes from which every possible
    ///     path eventually leads to a terminal node.
    /// </summary>
    /// <param name="graph">The adjacency list representation of the directed graph.</param>
    /// <returns>A sorted list of all safe node identifiers.</returns>
    IList<int> EventualSafeNodes(int[][] graph);
}