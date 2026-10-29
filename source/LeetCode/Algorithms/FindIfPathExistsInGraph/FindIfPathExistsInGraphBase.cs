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

/// <inheritdoc />
public abstract class FindIfPathExistsInGraphBase : IFindIfPathExistsInGraph
{
    /// <inheritdoc />
    public abstract bool ValidPath(int n, int[][] edges, int source, int destination);

    /// <summary>
    ///     Builds the adjacency lists of the undirected graph with <paramref name="n" /> vertices and
    ///     <paramref name="edges" />.
    /// </summary>
    /// <param name="n">The number of vertices, labeled from <c>0</c> to <c>n - 1</c>.</param>
    /// <param name="edges">The undirected edges, each given as a pair of vertices.</param>
    /// <returns>The adjacency lists, indexed by vertex.</returns>
    /// <remarks>
    ///     Time complexity - O(v + e), where v is the number of vertices and e is the number of edges
    ///     Space complexity - O(v + e), where v is the number of vertices and e is the number of edges
    /// </remarks>
    protected static List<int>[] BuildGraph(int n, int[][] edges)
    {
        var graph = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];

            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        return graph;
    }
}