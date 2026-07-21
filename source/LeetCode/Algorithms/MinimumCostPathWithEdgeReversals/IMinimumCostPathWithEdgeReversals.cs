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

namespace LeetCode.Algorithms.MinimumCostPathWithEdgeReversals;

/// <summary>
///     https://leetcode.com/problems/minimum-cost-path-with-edge-reversals/description/
/// </summary>
public interface IMinimumCostPathWithEdgeReversals
{
    /// <summary>
    ///     Finds the minimum total cost to travel from node 0 to node <paramref name="n" /> - 1 in a directed weighted graph,
    ///     where an incoming edge of the current node may be reversed and immediately traversed at twice its cost.
    /// </summary>
    /// <param name="n">The number of nodes in the graph.</param>
    /// <param name="edges">The directed edges, each expressed as a source node, a target node and a cost.</param>
    /// <returns>The minimum total cost to travel from node 0 to node <paramref name="n" /> - 1, or -1 if no such path exists.</returns>
    int MinCost(int n, int[][] edges);
}