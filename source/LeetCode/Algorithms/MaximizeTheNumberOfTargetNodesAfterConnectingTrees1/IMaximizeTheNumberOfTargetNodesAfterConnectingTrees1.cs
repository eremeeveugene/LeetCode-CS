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

namespace LeetCode.Algorithms.MaximizeTheNumberOfTargetNodesAfterConnectingTrees1;

/// <summary>
///     https://leetcode.com/problems/maximize-the-number-of-target-nodes-after-connecting-trees-i/description/
/// </summary>
public interface IMaximizeTheNumberOfTargetNodesAfterConnectingTrees1
{
    /// <summary>
    ///     For each node in the first tree (described by <paramref name="edges1" />), determines the maximum number of
    ///     target nodes obtainable by connecting it with a single edge to some node in the second tree (described by
    ///     <paramref name="edges2" />), where a node is a target if its distance to the source node is at most
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="edges1">The edges of the first tree.</param>
    /// <param name="edges2">The edges of the second tree.</param>
    /// <param name="k">The maximum distance for a node to be considered a target node.</param>
    /// <returns>An array where each element is the maximum number of target nodes for the corresponding node in the first tree.</returns>
    int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k);
}