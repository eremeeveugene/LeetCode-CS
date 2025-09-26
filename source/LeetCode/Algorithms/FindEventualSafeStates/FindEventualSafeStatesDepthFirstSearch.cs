// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindEventualSafeStates;

/// <inheritdoc />
public class FindEventualSafeStatesDepthFirstSearch : IFindEventualSafeStates
{
    /// <summary>
    ///     Time complexity - O(n + E), where n is a number of nodes, E is a number of edges
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="graph"></param>
    /// <returns></returns>
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        var n = graph.Length;

        Span<int> states = stackalloc int[n];

        var result = new List<int>();

        for (var node = 0; node < n; node++)
        {
            if (!IsSafeNode(node, graph, states))
            {
                continue;
            }

            result.Add(node);
        }

        return result;
    }

    private static bool IsSafeNode(int node, int[][] graph, Span<int> states)
    {
        switch (states[node])
        {
            case 1: return true;
            case 2: return false;
        }

        var adjacentNodes = graph[node];
        var adjacentNodesLength = adjacentNodes.Length;

        states[node] = 2;

        for (var i = 0; i < adjacentNodesLength; i++)
        {
            var adjacentNode = graph[node][i];

            if (IsSafeNode(adjacentNode, graph, states))
            {
                continue;
            }

            return false;
        }

        states[node] = 1;

        return true;
    }
}