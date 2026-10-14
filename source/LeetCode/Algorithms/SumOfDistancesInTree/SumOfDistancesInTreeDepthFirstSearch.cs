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

        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];

            int u = edge[0], v = edge[1];

            graph[u].Add(v);
            graph[v].Add(u);
        }

        var parents = new int[n];
        var order = new int[n];
        var stack = new int[n];

        var orderLength = 0;
        var stackSize = 0;

        parents[0] = -1;
        stack[stackSize++] = 0;

        while (stackSize > 0)
        {
            var node = stack[--stackSize];

            order[orderLength++] = node;

            var neighbors = graph[node];

            for (var i = 0; i < neighbors.Count; i++)
            {
                var child = neighbors[i];

                if (child == parents[node])
                {
                    continue;
                }

                parents[child] = node;

                stack[stackSize++] = child;
            }
        }

        var count = new int[n];
        var ans = new int[n];

        for (var i = 0; i < n; i++)
        {
            count[i] = 1;
        }

        for (var i = n - 1; i > 0; i--)
        {
            var node = order[i];
            var parent = parents[node];

            count[parent] += count[node];
            ans[parent] += ans[node] + count[node];
        }

        for (var i = 1; i < n; i++)
        {
            var node = order[i];
            var parent = parents[node];

            ans[node] = ans[parent] - count[node] + n - count[node];
        }

        return ans;
    }
}