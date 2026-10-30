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

namespace LeetCode.Algorithms.ShortestPathWithAtMostKConsecutiveIdenticalCharacters;

/// <inheritdoc />
public sealed class ShortestPathWithAtMostKConsecutiveIdenticalCharactersAdjacencyListPriorityQueue
    : IShortestPathWithAtMostKConsecutiveIdenticalCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((m + n) * k * log(n * k)), where m is the number of edges and n is the number of nodes
    ///     Space complexity - O(m + n * k), where m is the number of edges and n is the number of nodes
    /// </remarks>
    public int ShortestPath(int n, int[][] edges, string labels, int k)
    {
        var graph = BuildGraph(n, edges);

        var distances = CreateDistances(n, k);

        distances[0, 1] = 0;

        var statesPriorityQueue = new PriorityQueue<(int Node, int RunLength), int>();

        statesPriorityQueue.Enqueue((0, 1), 0);

        while (statesPriorityQueue.TryDequeue(out var state, out var distance))
        {
            var (node, runLength) = state;

            if (distance > distances[node, runLength])
            {
                continue;
            }

            if (node == n - 1)
            {
                return distance;
            }

            var neighbors = graph[node];

            for (var i = 0; i < neighbors.Count; i++)
            {
                var (target, weight) = neighbors[i];

                var targetRunLength = GetTargetRunLength(labels, node, target, runLength);

                if (targetRunLength > k)
                {
                    continue;
                }

                var targetDistance = distance + weight;

                if (targetDistance >= distances[target, targetRunLength])
                {
                    continue;
                }

                distances[target, targetRunLength] = targetDistance;

                statesPriorityQueue.Enqueue((target, targetRunLength), targetDistance);
            }
        }

        return -1;
    }

    /// <summary>
    ///     Builds the adjacency list of the directed graph.
    /// </summary>
    /// <param name="n">The number of nodes in the graph.</param>
    /// <param name="edges">The directed edges, each expressed as a source node, a target node and a weight.</param>
    /// <returns>The outgoing edges of each node, each expressed as a target node and a weight.</returns>
    /// <remarks>
    ///     Time complexity - O(m + n), where m is the number of edges and n is the number of nodes
    ///     Space complexity - O(m + n), where m is the number of edges and n is the number of nodes
    /// </remarks>
    private static List<(int Target, int Weight)>[] BuildGraph(int n, int[][] edges)
    {
        var graph = new List<(int Target, int Weight)>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        var m = edges.Length;

        for (var i = 0; i < m; i++)
        {
            var edge = edges[i];

            var source = edge[0];
            var target = edge[1];
            var weight = edge[2];

            graph[source].Add((target, weight));
        }

        return graph;
    }

    /// <summary>
    ///     Creates the table of the minimum distances to each (node, run length) state, filled with
    ///     <see cref="int.MaxValue" />.
    /// </summary>
    /// <param name="n">The number of nodes in the graph.</param>
    /// <param name="k">The maximum allowed run length.</param>
    /// <returns>The table indexed by node and run length, where run length 0 is never used.</returns>
    /// <remarks>
    ///     Time complexity - O(n * k)
    ///     Space complexity - O(n * k)
    /// </remarks>
    private static int[,] CreateDistances(int n, int k)
    {
        var distances = new int[n, k + 1];

        for (var node = 0; node < n; node++)
        {
            for (var runLength = 0; runLength <= k; runLength++)
            {
                distances[node, runLength] = int.MaxValue;
            }
        }

        return distances;
    }

    /// <summary>
    ///     Gets the length of the run of identical labels ending at <paramref name="target" /> after moving to it from
    ///     <paramref name="node" />.
    /// </summary>
    /// <param name="labels">The labels of the nodes.</param>
    /// <param name="node">The current node.</param>
    /// <param name="target">The next node.</param>
    /// <param name="runLength">The length of the run of identical labels ending at <paramref name="node" />.</param>
    /// <returns>
    ///     <paramref name="runLength" /> + 1 if both nodes share a label; otherwise, 1.
    /// </returns>
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    private static int GetTargetRunLength(string labels, int node, int target, int runLength)
    {
        var label = labels[node];
        var targetLabel = labels[target];

        return label == targetLabel ? runLength + 1 : 1;
    }
}