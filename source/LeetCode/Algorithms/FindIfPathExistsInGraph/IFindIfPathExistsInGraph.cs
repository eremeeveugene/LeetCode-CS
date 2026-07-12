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

namespace LeetCode.Algorithms.FindIfPathExistsInGraph;

/// <summary>
///     https://leetcode.com/problems/find-if-path-exists-in-graph/
/// </summary>
public interface IFindIfPathExistsInGraph
{
    /// <summary>
    ///     Determines whether a path exists between <paramref name="source" /> and <paramref name="destination" /> in the
    ///     undirected graph of <paramref name="n" /> vertices described by <paramref name="edges" />.
    /// </summary>
    /// <param name="n">The number of vertices in the graph, labeled from 0 to n - 1.</param>
    /// <param name="edges">The array of undirected edges connecting pairs of vertices.</param>
    /// <param name="source">The starting vertex.</param>
    /// <param name="destination">The target vertex.</param>
    /// <returns>
    ///     <see langword="true" /> if a path exists between <paramref name="source" /> and
    ///     <paramref name="destination" />; otherwise, <see langword="false" />.
    /// </returns>
    bool ValidPath(int n, int[][] edges, int source, int destination);
}