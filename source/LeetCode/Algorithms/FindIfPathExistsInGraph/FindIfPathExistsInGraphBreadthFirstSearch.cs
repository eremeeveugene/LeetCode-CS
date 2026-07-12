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
public sealed class FindIfPathExistsInGraphBreadthFirstSearch : IFindIfPathExistsInGraph
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

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var queue = new Queue<int>();

        queue.Enqueue(source);

        var visited = new HashSet<int>(source);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            foreach (var neighbor in graph[current])
            {
                if (neighbor == destination)
                {
                    return true;
                }

                if (visited.Add(neighbor))
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        return false;
    }
}