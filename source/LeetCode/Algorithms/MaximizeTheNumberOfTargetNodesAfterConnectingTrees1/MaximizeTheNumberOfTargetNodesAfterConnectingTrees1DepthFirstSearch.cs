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

namespace LeetCode.Algorithms.MaximizeTheNumberOfTargetNodesAfterConnectingTrees1;

/// <inheritdoc />
public class MaximizeTheNumberOfTargetNodesAfterConnectingTrees1DepthFirstSearch :
    IMaximizeTheNumberOfTargetNodesAfterConnectingTrees1
{
    /// <summary>
    ///     Time complexity - O(n^2 + m^2)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="edges1"></param>
    /// <param name="edges2"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        var n = edges1.Length + 1;
        var m = edges2.Length + 1;

        var graph1 = BuildGraph(edges1, n);
        var graph2 = BuildGraph(edges2, m);

        var bestFromGraph2 = 0;

        for (var j = 0; j < m; j++)
        {
            bestFromGraph2 = Math.Max(bestFromGraph2, CountWithin(graph2, j, k - 1));
        }

        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            result[i] = CountWithin(graph1, i, k) + bestFromGraph2;
        }

        return result;
    }

    private static List<int>[] BuildGraph(int[][] edges, int size)
    {
        var graph = new List<int>[size];

        for (var i = 0; i < size; i++)
        {
            graph[i] = [];
        }

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        return graph;
    }

    private static int CountWithin(List<int>[] graphs, int start, int maxDepth)
    {
        if (maxDepth < 0)
        {
            return 0;
        }

        var count = 0;

        var visited = new bool[graphs.Length];

        var nodesQueue = new Queue<(int Index, int Depth)>();

        nodesQueue.Enqueue((start, 0));

        visited[start] = true;

        while (nodesQueue.Count > 0)
        {
            var node = nodesQueue.Dequeue();

            count++;

            if (node.Depth == maxDepth)
            {
                continue;
            }

            foreach (var graph in graphs[node.Index].Where(graph => !visited[graph]))
            {
                visited[graph] = true;

                nodesQueue.Enqueue((graph, node.Depth + 1));
            }
        }

        return count;
    }
}