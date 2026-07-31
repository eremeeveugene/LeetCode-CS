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

namespace LeetCode.Algorithms.SumOfDistancesInTree;

/// <inheritdoc />
public sealed class SumOfDistancesInTreeDepthFirstSearch : ISumOfDistancesInTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        var graph = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1];

            graph[u].Add(v);
            graph[v].Add(u);
        }

        var count = new int[n];
        var ans = new int[n];

        Dfs(0, -1, graph, count, ans);

        Dfs2(0, -1, graph, count, ans);

        return ans;
    }

    private static void Dfs(int node, int parent, List<int>[] graph, int[] count, int[] ans)
    {
        count[node] = 1;

        var neighbors = graph[node];

        for (var i = 0; i < neighbors.Count; i++)
        {
            var child = neighbors[i];

            if (child == parent)
            {
                continue;
            }

            Dfs(child, node, graph, count, ans);

            count[node] += count[child];
            ans[node] += ans[child] + count[child];
        }
    }

    private static void Dfs2(int node, int parent, List<int>[] graph, int[] count, int[] ans)
    {
        var neighbors = graph[node];

        for (var i = 0; i < neighbors.Count; i++)
        {
            var child = neighbors[i];

            if (child == parent)
            {
                continue;
            }

            ans[child] = ans[node] - count[child] + count.Length - count[child];

            Dfs2(child, node, graph, count, ans);
        }
    }
}