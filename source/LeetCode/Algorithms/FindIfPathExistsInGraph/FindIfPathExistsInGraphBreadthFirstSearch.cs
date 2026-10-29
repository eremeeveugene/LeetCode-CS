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
public sealed class FindIfPathExistsInGraphBreadthFirstSearch : FindIfPathExistsInGraphBase
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(v + e), where v is the number of vertices and e is the number of edges
    ///     Space complexity - O(v + e), where v is the number of vertices and e is the number of edges
    /// </remarks>
    public override bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        if (source == destination)
        {
            return true;
        }

        var graph = BuildGraph(n, edges);

        var queue = new Queue<int>();

        queue.Enqueue(source);

        var visited = new HashSet<int> { source };

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            var neighbors = graph[current];

            var m = neighbors.Count;

            for (var i = 0; i < m; i++)
            {
                var neighbor = neighbors[i];

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