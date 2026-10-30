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

namespace LeetCode.Algorithms.ShortestPathWithAtMostKConsecutiveIdenticalCharacters;

/// <summary>
///     https://leetcode.com/problems/shortest-path-with-at-most-k-consecutive-identical-characters/description/
/// </summary>
public interface IShortestPathWithAtMostKConsecutiveIdenticalCharacters
{
    /// <summary>
    ///     Finds the minimum total edge weight of a path from node 0 to node <paramref name="n" /> - 1 in a directed weighted
    ///     graph, such that the concatenation of the node labels along the path contains at most <paramref name="k" />
    ///     consecutive identical characters.
    /// </summary>
    /// <param name="n">The number of nodes in the graph.</param>
    /// <param name="edges">The directed edges, each expressed as a source node, a target node and a weight.</param>
    /// <param name="labels">The labels of the nodes, consisting of lowercase English letters.</param>
    /// <param name="k">The maximum allowed number of consecutive identical labels along the path.</param>
    /// <returns>
    ///     The minimum total edge weight of a valid path from node 0 to node <paramref name="n" /> - 1, or -1 if no such
    ///     path exists.
    /// </returns>
    int ShortestPath(int n, int[][] edges, string labels, int k);
}