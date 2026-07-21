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

namespace LeetCode.Algorithms.MinimumCostPathWithEdgeReversals;

/// <inheritdoc />
public sealed class MinimumCostPathWithEdgeReversalsDijkstra : IMinimumCostPathWithEdgeReversals
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((m + n) * log n), where m is the number of edges and n is the number of nodes
    ///     Space complexity - O(m + n), where m is the number of edges and n is the number of nodes
    /// </remarks>
    public int MinCost(int n, int[][] edges)
    {
        var startLength = n + 1;

        Span<int> start = stackalloc int[startLength];

        var m = edges.Length;

        for (var i = 0; i < m; i++)
        {
            var edge = edges[i];

            var u = edge[0] + 1;
            var v = edge[1] + 1;

            start[u]++;
            start[v]++;
        }

        for (var i = 1; i < startLength; i++)
        {
            start[i] += start[i - 1];
        }

        var directedEdgesCount = m * 2;

        Span<ushort> targets = stackalloc ushort[directedEdgesCount];
        Span<ushort> costs = stackalloc ushort[directedEdgesCount];

        for (var i = 0; i < m; i++)
        {
            var edge = edges[i];

            var source = edge[0];
            var target = edge[1];
            var cost = edge[2];

            var forwardIndex = start[source]++;

            targets[forwardIndex] = (ushort)target;
            costs[forwardIndex] = (ushort)cost;

            var reversedIndex = start[target]++;

            targets[reversedIndex] = (ushort)source;
            costs[reversedIndex] = (ushort)(cost * 2);
        }

        for (var i = n; i > 0; i--)
        {
            start[i] = start[i - 1];
        }

        start[0] = 0;

        Span<int> distances = stackalloc int[n];

        distances.Fill(int.MaxValue);
        distances[0] = 0;

        var nodesPriorityQueue = new PriorityQueue<int, int>();

        nodesPriorityQueue.Enqueue(0, 0);

        while (nodesPriorityQueue.TryDequeue(out var node, out var distance))
        {
            if (node == n - 1)
            {
                return distance;
            }

            if (distance > distances[node])
            {
                continue;
            }

            for (var i = start[node]; i < start[node + 1]; i++)
            {
                var target = targets[i];

                var targetDistance = distance + costs[i];

                if (targetDistance >= distances[target])
                {
                    continue;
                }

                distances[target] = targetDistance;

                nodesPriorityQueue.Enqueue(target, targetDistance);
            }
        }

        return -1;
    }
}