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

namespace LeetCode.Algorithms.MinimumHeightTrees;

/// <inheritdoc />
public class MinimumHeightTreesLeafPruning : IMinimumHeightTrees
{
    /// <summary>
    ///     Time complexity - O(V + E), where V is the number of vertices(nodes) and E is the number of edges.
    ///     Space complexity - O(V), where V is the number of vertices(nodes).
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1)
        {
            return new List<int> { 0 };
        }

        var graph = new List<HashSet<int>>();

        for (var i = 0; i < n; i++)
        {
            graph.Add([]);
        }

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var leaves = new List<int>();

        for (var i = 0; i < n; i++)
        {
            if (graph[i].Count == 1)
            {
                leaves.Add(i);
            }
        }

        var remainingNodes = n;

        while (remainingNodes > 2)
        {
            remainingNodes -= leaves.Count;

            var newLeaves = new List<int>();

            foreach (var leaf in leaves)
            {
                var neighbor = graph[leaf].First();

                graph[neighbor].Remove(leaf);

                if (graph[neighbor].Count == 1)
                {
                    newLeaves.Add(neighbor);
                }
            }

            leaves = newLeaves;
        }

        return leaves;
    }
}