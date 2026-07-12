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

namespace LeetCode.Algorithms.PathWithMaximumProbability;

/// <inheritdoc />
public abstract class PathWithMaximumProbabilityBase : IPathWithMaximumProbability
{
    public abstract double MaxProbability(int n, int[][] edges, double[] successProbability, int startNode, int endNode);

    /// <summary>
    ///     Builds an adjacency dictionary mapping each node to its neighbors and the success probability of the connecting
    ///     edge.
    /// </summary>
    /// <param name="edges">The undirected edges of the graph.</param>
    /// <param name="successProbability">The success probability of each edge.</param>
    /// <returns>A dictionary mapping each node to its list of (neighbor, probability) pairs.</returns>
    /// <remarks>
    ///     Time complexity - O(n), where n is the number of edges
    ///     Space complexity - O(n + m), where n is the number of edges and m is the number of nodes
    /// </remarks>
    protected static Dictionary<int, List<(int Node, double Probability)>> GetEdgesDictionary(int[][] edges, double[] successProbability)
    {
        var edgesDictionary = new Dictionary<int, List<(int Node, double Probability)>>();

        for (var i = 0; i < edges.Length; i++)
        {
            if (edgesDictionary.TryGetValue(edges[i][0], out var headEdge))
            {
                headEdge.Add((edges[i][1], successProbability[i]));
            }
            else
            {
                edgesDictionary[edges[i][0]] = [(edges[i][1], successProbability[i])];
            }

            if (edgesDictionary.TryGetValue(edges[i][1], out var tailEdge))
            {
                tailEdge.Add((edges[i][0], successProbability[i]));
            }
            else
            {
                edgesDictionary[edges[i][1]] = [(edges[i][0], successProbability[i])];
            }
        }

        return edgesDictionary;
    }
}