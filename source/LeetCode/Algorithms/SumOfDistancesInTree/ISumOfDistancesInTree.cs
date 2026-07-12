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

namespace LeetCode.Algorithms.SumOfDistancesInTree;

/// <summary>
///     https://leetcode.com/problems/sum-of-distances-in-tree/description/
/// </summary>
public interface ISumOfDistancesInTree
{
    /// <summary>
    ///     Computes, for each node in an undirected tree of <paramref name="n" /> nodes connected by
    ///     <paramref name="edges" />, the sum of the distances from that node to every other node.
    /// </summary>
    /// <param name="n">The number of nodes in the tree, labeled from 0 to <paramref name="n" /> - 1.</param>
    /// <param name="edges">The edges of the tree, where each entry contains two node labels connected by an edge.</param>
    /// <returns>An array where the value at each index is the sum of distances from that node to all other nodes.</returns>
    int[] SumOfDistancesInTree(int n, int[][] edges);
}