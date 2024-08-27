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
public class PathWithMaximumProbabilityDepthFirstSearch : PathWithMaximumProbabilityBase
{
    /// <summary>
    ///     Time complexity - O(m + n), where m is the number of edges and n is the number of nodes
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

        return GetMaxProbability(edgesDictionary, [startNode], startNode, endNode, 0);
    }

    private static double GetMaxProbability(Dictionary<int, List<(int Node, double Probability)>> edgesDictionary,
        HashSet<int> visitedEdges, int currentNode, int endNode, double probability)
    {
        if (currentNode == endNode)
        {
            return probability;
        }

        double maxProbability = 0;

        foreach (var edge in edgesDictionary[currentNode])
        {
            if (!visitedEdges.Add(edge.Node))
            {
                continue;
            }

            var currentProbability = probability == 0 ? edge.Probability : probability * edge.Probability;

            if (currentProbability <= maxProbability)
            {
                continue;
            }

            var currentMaxProbability =
                GetMaxProbability(edgesDictionary, visitedEdges, edge.Node, endNode, currentProbability);

            maxProbability = Math.Max(maxProbability, currentMaxProbability);

            visitedEdges.Remove(edge.Node);
        }

        return maxProbability;
    }
}