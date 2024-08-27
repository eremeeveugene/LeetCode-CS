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

namespace LeetCode.Algorithms.PathWithMaximumProbability;

/// <inheritdoc />
public class PathWithMaximumProbabilityDijkstra : PathWithMaximumProbabilityBase
{
    /// <summary>
    ///     Time complexity - O((m + n) log n), where m is the number of edges
    ///     Space complexity - O(m + n), where m is the number of edges and n is the number of nodes
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <param name="successProbability"></param>
    /// <param name="startNode"></param>
    /// <param name="endNode"></param>
    /// <returns></returns>
    public override double MaxProbability(int n, int[][] edges, double[] successProbability, int startNode, int endNode)
    {
        if (edges.Length == 0 || successProbability.Length == 0 || startNode == endNode)
        {
            return startNode == endNode ? 1.0 : 0;
        }

        var edgesDictionary = GetEdgesDictionary(edges, successProbability);

        if (!edgesDictionary.ContainsKey(startNode))
        {
            return 0;
        }

        return GetMaxProbability(edgesDictionary, n, startNode, endNode);
    }

    private static double GetMaxProbability(Dictionary<int, List<(int Node, double Probability)>> edgesDictionary,
        int n, int startNode, int endNode)
    {
        var probabilityNodesPriorityQueue = new PriorityQueue<(double Probability, int Node), double>();

        probabilityNodesPriorityQueue.Enqueue((1.0, startNode), -1.0);

        var maxProbability = new double[n];

        maxProbability[startNode] = 1.0;

        while (probabilityNodesPriorityQueue.Count > 0)
        {
            var probabilityNode = probabilityNodesPriorityQueue.Dequeue();

            if (probabilityNode.Node == endNode)
            {
                return probabilityNode.Probability;
            }

            foreach (var edge in edgesDictionary[probabilityNode.Node])
            {
                var probability = probabilityNode.Probability * edge.Probability;

                if (probability <= maxProbability[edge.Node])
                {
                    continue;
                }

                maxProbability[edge.Node] = probability;

                probabilityNodesPriorityQueue.Enqueue((probability, edge.Node), probability * -1);
            }
        }

        return 0;
    }
}