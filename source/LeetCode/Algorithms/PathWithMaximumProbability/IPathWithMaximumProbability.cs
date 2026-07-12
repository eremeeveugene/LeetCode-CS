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

namespace LeetCode.Algorithms.PathWithMaximumProbability;

/// <summary>
///     https://leetcode.com/problems/path-with-maximum-probability/description/
/// </summary>
public interface IPathWithMaximumProbability
{
    /// <summary>
    ///     Finds the path from <paramref name="startNode" /> to <paramref name="endNode" /> in an undirected graph of
    ///     <paramref name="n" /> nodes with the given <paramref name="edges" /> and corresponding
    ///     <paramref name="successProbability" /> values that maximizes the product of edge probabilities.
    /// </summary>
    /// <param name="n">The number of nodes in the graph.</param>
    /// <param name="edges">The list of undirected edges, each expressed as a pair of node indices.</param>
    /// <param name="successProbability">The success probability associated with each edge in <paramref name="edges" />.</param>
    /// <param name="startNode">The node to start the path from.</param>
    /// <param name="endNode">The node to end the path at.</param>
    /// <returns>The greatest probability of success along any path from <paramref name="startNode" /> to <paramref name="endNode" />, or 0 if no path exists.</returns>
    double MaxProbability(int n, int[][] edges, double[] successProbability, int startNode, int endNode);
}