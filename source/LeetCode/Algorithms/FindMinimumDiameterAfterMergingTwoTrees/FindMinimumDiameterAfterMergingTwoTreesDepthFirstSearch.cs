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

namespace LeetCode.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

/// <inheritdoc />
public class FindMinimumDiameterAfterMergingTwoTreesDepthFirstSearch : IFindMinimumDiameterAfterMergingTwoTrees
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="edges1"></param>
    /// <param name="edges2"></param>
    /// <returns></returns>
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
    {
        var adjList1 = BuildAdjList(edges1.Length + 1, edges1);
        var adjList2 = BuildAdjList(edges2.Length + 1, edges2);

        var diameter1 = FindDiameter(adjList1, 0, -1).Item1;
        var diameter2 = FindDiameter(adjList2, 0, -1).Item1;

        var combinedDiameter = (int)Math.Ceiling(diameter1 / 2.0) + (int)Math.Ceiling(diameter2 / 2.0) + 1;

        return Math.Max(Math.Max(diameter1, diameter2), combinedDiameter);
    }

    private static List<List<int>> BuildAdjList(int size, int[][] edges)
    {
        var adjList = new List<List<int>>(size);

        for (var i = 0; i < size; i++)
        {
            adjList.Add([]);
        }

        foreach (var edge in edges)
        {
            adjList[edge[0]].Add(edge[1]);
            adjList[edge[1]].Add(edge[0]);
        }

        return adjList;
    }

    private static (int Diameter, int Depth) FindDiameter(List<List<int>> adjList, int node, int parent)
    {
        var maxDepth1 = 0;
        var maxDepth2 = 0;
        var diameter = 0;

        foreach (var neighbor in adjList[node].Where(neighbor => neighbor != parent))
        {
            var (childDiameter, childDepth) = FindDiameter(adjList, neighbor, node);

            var depth = childDepth + 1;

            diameter = Math.Max(diameter, childDiameter);

            if (depth > maxDepth1)
            {
                maxDepth2 = maxDepth1;
                maxDepth1 = depth;
            }
            else if (depth > maxDepth2)
            {
                maxDepth2 = depth;
            }
        }

        diameter = Math.Max(diameter, maxDepth1 + maxDepth2);

        return (diameter, maxDepth1);
    }
}