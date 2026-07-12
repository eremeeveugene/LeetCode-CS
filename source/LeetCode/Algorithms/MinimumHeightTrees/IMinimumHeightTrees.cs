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

namespace LeetCode.Algorithms.MinimumHeightTrees;

/// <summary>
///     https://leetcode.com/problems/minimum-height-trees/
/// </summary>
public interface IMinimumHeightTrees
{
    /// <summary>
    ///     Finds all nodes that, when chosen as the root of the tree with <paramref name="n" /> nodes connected by
    ///     <paramref name="edges" />, minimize the tree's height.
    /// </summary>
    /// <param name="n">The number of nodes in the tree, labeled from 0 to n - 1.</param>
    /// <param name="edges">The edges connecting the nodes of the tree.</param>
    /// <returns>A list of node labels that can serve as roots producing the minimum height.</returns>
    IList<int> FindMinHeightTrees(int n, int[][] edges);
}