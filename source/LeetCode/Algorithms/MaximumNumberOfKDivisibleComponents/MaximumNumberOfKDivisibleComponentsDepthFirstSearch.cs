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

namespace LeetCode.Algorithms.MaximumNumberOfKDivisibleComponents;

/// <inheritdoc />
public sealed class MaximumNumberOfKDivisibleComponentsDepthFirstSearch : IMaximumNumberOfKDivisibleComponents
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </remarks>
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        var graph = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];
        var components = 0;

        var totalSumMod = MaxKDivisibleComponents(0, graph, visited, values, k, ref components);

        if (totalSumMod == 0)
        {
            components++;
        }

        return components;
    }

    private static int MaxKDivisibleComponents(int node, List<int>[] graph, bool[] visited, int[] values, int k, ref int components)
    {
        visited[node] = true;

        var subtreeSumMod = values[node] % k;

        foreach (var neighbor in graph[node].Where(neighbor => !visited[neighbor]))
        {
            var childSumMod = MaxKDivisibleComponents(neighbor, graph, visited, values, k, ref components);

            if (childSumMod == 0)
            {
                components++;
            }
            else
            {
                subtreeSumMod = (subtreeSumMod + childSumMod) % k;
            }
        }

        return subtreeSumMod;
    }
}