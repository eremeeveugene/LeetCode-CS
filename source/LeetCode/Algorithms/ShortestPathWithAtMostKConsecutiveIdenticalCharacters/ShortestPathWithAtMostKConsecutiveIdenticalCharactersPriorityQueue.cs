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
public sealed class ShortestPathWithAtMostKConsecutiveIdenticalCharactersPriorityQueue : IShortestPathWithAtMostKConsecutiveIdenticalCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((m + n) * k * log(n * k)), where m is the number of edges and n is the number of nodes
    ///     Space complexity - O(m + n * k), where m is the number of edges and n is the number of nodes
    /// </remarks>
    public int ShortestPath(int n, int[][] edges, string labels, int k)
    {
        Span<int> start = stackalloc int[n + 1];

        var m = edges.Length;

        Span<ushort> targets = stackalloc ushort[m];
        Span<ushort> weights = stackalloc ushort[m];

        BuildAdjacency(n, edges, start, targets, weights);

        var distances = new int[n * k];

        Array.Fill(distances, int.MaxValue);

        distances[0] = 0;

        var statesPriorityQueue = new PriorityQueue<int, int>();

        statesPriorityQueue.Enqueue(0, 0);

        while (statesPriorityQueue.TryDequeue(out var state, out var distance))
        {
            if (distance > distances[state])
            {
                continue;
            }

            var node = state / k;

            if (node == n - 1)
            {
                return distance;
            }

            var runLength = (state % k) + 1;

            for (var i = start[node]; i < start[node + 1]; i++)
            {
                var target = targets[i];

                var targetRunLength = GetTargetRunLength(labels, node, target, runLength);

                if (targetRunLength > k)
                {
                    continue;
                }

                var targetState = (target * k) + targetRunLength - 1;

                var targetDistance = distance + weights[i];

                if (targetDistance >= distances[targetState])
                {
                    continue;
                }

                distances[targetState] = targetDistance;

                statesPriorityQueue.Enqueue(targetState, targetDistance);
            }
        }

        return -1;
    }

    /// <summary>
    ///     Builds the compressed adjacency list of the directed graph, where the outgoing edges of node <c>u</c> occupy
    ///     indices <c>start[u]</c> to <c>start[u + 1] - 1</c> of <paramref name="targets" /> and
    ///     <paramref name="weights" />.
    /// </summary>
    /// <param name="n">The number of nodes in the graph.</param>
    /// <param name="edges">The directed edges, each expressed as a source node, a target node and a weight.</param>
    /// <param name="start">The buffer of length <paramref name="n" /> + 1 that receives the start index of each node.</param>
    /// <param name="targets">The buffer that receives the target node of each edge.</param>
    /// <param name="weights">The buffer that receives the weight of each edge.</param>
    /// <remarks>
    ///     Time complexity - O(m + n), where m is the number of edges and n is the number of nodes
    ///     Space complexity - O(1)
    /// </remarks>
    private static void BuildAdjacency(int n, int[][] edges, Span<int> start, Span<ushort> targets, Span<ushort> weights)
    {
        var m = edges.Length;

        for (var i = 0; i < m; i++)
        {
            var edge = edges[i];

            var source = edge[0] + 1;

            start[source]++;
        }

        for (var i = 1; i <= n; i++)
        {
            start[i] += start[i - 1];
        }

        for (var i = 0; i < m; i++)
        {
            var edge = edges[i];

            var source = edge[0];
            var target = edge[1];
            var weight = edge[2];

            var edgeIndex = start[source];

            start[source]++;

            targets[edgeIndex] = (ushort)target;
            weights[edgeIndex] = (ushort)weight;
        }

        for (var i = n; i > 0; i--)
        {
            start[i] = start[i - 1];
        }

        start[0] = 0;
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