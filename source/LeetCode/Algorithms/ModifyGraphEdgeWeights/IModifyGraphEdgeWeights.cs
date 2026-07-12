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

namespace LeetCode.Algorithms.ModifyGraphEdgeWeights;

/// <summary>
///     https://leetcode.com/problems/modify-graph-edge-weights/description/
/// </summary>
public interface IModifyGraphEdgeWeights
{
    /// <summary>
    ///     Assigns positive integer weights to the edges of <paramref name="edges" /> that currently have a weight
    ///     of -1 so that the shortest path from <paramref name="source" /> to <paramref name="destination" /> in the
    ///     graph of <paramref name="n" /> nodes equals exactly <paramref name="target" />.
    /// </summary>
    /// <param name="n">The number of nodes in the graph, labeled from 0 to n - 1.</param>
    /// <param name="edges">The list of edges, each as [from, to, weight], where weight -1 means unassigned.</param>
    /// <param name="source">The node to compute the shortest path from.</param>
    /// <param name="destination">The node to compute the shortest path to.</param>
    /// <param name="target">The desired shortest path distance between <paramref name="source" /> and <paramref name="destination" />.</param>
    /// <returns>The edges with weights assigned so the shortest path equals <paramref name="target" />, or an empty array if impossible.</returns>
    int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target);
}