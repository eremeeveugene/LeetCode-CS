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
public sealed class FindIfPathExistsInGraphDepthFirstSearch : IFindIfPathExistsInGraph
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(v + e), where v is the number of vertices and e is the number of edges
    ///     Space complexity - O(v + e), where v is the number of vertices and e is the number of edges
    /// </remarks>
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        if (source == destination)
        {
            return true;
        }

        var graph = new Dictionary<int, List<int>>();

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

        return ValidPath(new HashSet<int>(), graph, source, destination);
    }

    private static bool ValidPath(ISet<int> visited, IReadOnlyDictionary<int, List<int>> graph, int current, int target)
    {
        if (current == target)
        {
            return true;
        }

        visited.Add(current);

        var neighbors = graph[current];

        for (var i = 0; i < neighbors.Count; i++)
        {
            var neighbor = neighbors[i];

            if (!visited.Contains(neighbor) && ValidPath(visited, graph, neighbor, target))
            {
                return true;
            }
        }

        return false;
    }
}