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
        var startLength = n + 1;

        Span<int> start = stackalloc int[startLength];

        var m = edges.Length;

        for (var i = 0; i < m; i++)
        {
            var edge = edges[i];

            var source = edge[0] + 1;

            start[source]++;
        }

        for (var i = 1; i < startLength; i++)
        {
            start[i] += start[i - 1];
        }

        Span<ushort> targets = stackalloc ushort[m];
        Span<ushort> weights = stackalloc ushort[m];

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

        Span<int> distances = stackalloc int[n * k];

        distances.Fill(int.MaxValue);
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

            var label = labels[node];

            for (var i = start[node]; i < start[node + 1]; i++)
            {
                var target = targets[i];

                var targetLabel = labels[target];

                var targetRunLength = targetLabel == label ? runLength + 1 : 1;

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
}