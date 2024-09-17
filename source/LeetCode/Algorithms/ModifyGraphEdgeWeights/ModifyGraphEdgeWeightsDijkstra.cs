// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ModifyGraphEdgeWeights;

/// <inheritdoc />
public class ModifyGraphEdgeWeightsDijkstra : IModifyGraphEdgeWeights
{
    /// <summary>
    ///     Time complexity - O((n + m) log n)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <param name="source"></param>
    /// <param name="destination"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target)
    {
        var adjacencyEdges = new List<Edge>[n];

        for (var i = 0; i < n; i++)
        {
            adjacencyEdges[i] = [];
        }

        for (var i = 0; i < edges.Length; i++)
        {
            adjacencyEdges[edges[i][0]].Add(new Edge(edges[i][1], i));
            adjacencyEdges[edges[i][1]].Add(new Edge(edges[i][0], i));
        }

        var distances = new int[n, 2];

        for (var i = 0; i < n; i++)
        {
            distances[i, 0] = distances[i, 1] = i == source ? 0 : int.MaxValue;
        }

        Dijkstra(adjacencyEdges, edges, distances, source, 0, 0);

        var difference = target - distances[destination, 0];

        if (difference < 0)
        {
            return [];
        }

        Dijkstra(adjacencyEdges, edges, distances, source, difference, 1);

        if (distances[destination, 1] < target)
        {
            return [];
        }

        foreach (var edge in edges)
        {
            if (edge[2] == -1)
            {
                edge[2] = 1;
            }
        }

        return edges;
    }

    private static void Dijkstra(List<Edge>[] adjacencyEdges, int[][] edges, int[,] distances, int source,
        int difference, int run)
    {
        var edgeDistancesPriorityQueue = new PriorityQueue<EdgeDistance, int>();

        edgeDistancesPriorityQueue.Enqueue(new EdgeDistance(new Edge(source, -1), 0), 0);
        distances[source, run] = 0;

        while (edgeDistancesPriorityQueue.Count > 0)
        {
            var current = edgeDistancesPriorityQueue.Dequeue();

            if (current.Distance > distances[current.Edge.Node, run])
            {
                continue;
            }

            foreach (var edge in adjacencyEdges[current.Edge.Node])
            {
                var weight = edges[edge.Index][2];

                if (weight == -1)
                {
                    weight = 1;
                }

                if (run == 1 && edges[edge.Index][2] == -1)
                {
                    var newWeight = difference + distances[edge.Node, 0] - distances[current.Edge.Node, 1];

                    if (newWeight > weight)
                    {
                        edges[edge.Index][2] = weight = newWeight;
                    }
                }

                var newDistance = distances[current.Edge.Node, run] + weight;

                if (distances[edge.Node, run] <= newDistance)
                {
                    continue;
                }

                distances[edge.Node, run] = newDistance;
                edgeDistancesPriorityQueue.Enqueue(new EdgeDistance(edge, newDistance), newDistance);
            }
        }
    }

    private record Edge(int Node, int Index);

    private record EdgeDistance(Edge Edge, int Distance);
}