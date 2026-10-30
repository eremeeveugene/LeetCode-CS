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

namespace LeetCode.Algorithms.MinimumHeightTrees;

/// <inheritdoc />
public sealed class MinimumHeightTreesBreadthFirstSearch : IMinimumHeightTrees
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(V * (V + E)), where V is the number of vertices(nodes) and E is the number of edges.
    ///     Space complexity - O(V + E), where V is the number of vertices(nodes) and E is the number of edges.
    /// </remarks>
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1)
        {
            return [0];
        }

        var nodesDictionary = GetNodesDictionary(edges);

        var maxNodeDepths = GetMaxNodeDepth(nodesDictionary);

        var minDepth = int.MaxValue;

        for (var i = 0; i < maxNodeDepths.Count; i++)
        {
            minDepth = Math.Min(minDepth, maxNodeDepths[i].maxDepth);
        }

        var result = new List<int>();

        for (var i = 0; i < maxNodeDepths.Count; i++)
        {
            var (node, maxDepth) = maxNodeDepths[i];

            if (maxDepth == minDepth)
            {
                result.Add(node);
            }
        }

        return result;
    }

    private static Dictionary<int, List<int>> GetNodesDictionary(int[][] edges)
    {
        var nodesDictionary = new Dictionary<int, List<int>>();

        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];

            var root = edge[0];
            var leaf = edge[1];

            if (nodesDictionary.TryGetValue(root, out var rootValue))
            {
                rootValue.Add(leaf);
            }
            else
            {
                nodesDictionary.Add(root, [leaf]);
            }

            if (nodesDictionary.TryGetValue(leaf, out var leafValue))
            {
                leafValue.Add(root);
            }
            else
            {
                nodesDictionary.Add(leaf, [root]);
            }
        }

        return nodesDictionary;
    }

    private static List<(int node, int maxDepth)> GetMaxNodeDepth(Dictionary<int, List<int>> nodesDictionary)
    {
        var maxNodeDepths = new List<(int node, int maxDepth)>();

        var nodes = new int[nodesDictionary.Count];

        nodesDictionary.Keys.CopyTo(nodes, 0);

        for (var i = 0; i < nodes.Length; i++)
        {
            var node = nodes[i];
            var neighbors = nodesDictionary[node];

            var maxNodeDepth = 0;

            var nodesQueue = new Queue<(int, int)>();

            var visitedNodes = new HashSet<int> { node };

            for (var j = 0; j < neighbors.Count; j++)
            {
                nodesQueue.Enqueue((neighbors[j], 1));
            }

            while (nodesQueue.Count > 0)
            {
                var (currentNode, currentNodeDepth) = nodesQueue.Dequeue();

                visitedNodes.Add(currentNode);

                var currentNeighbors = nodesDictionary[currentNode];

                for (var j = 0; j < currentNeighbors.Count; j++)
                {
                    var edgesDictionaryItemCur = currentNeighbors[j];

                    if (visitedNodes.Contains(edgesDictionaryItemCur))
                    {
                        maxNodeDepth = Math.Max(maxNodeDepth, currentNodeDepth);
                    }
                    else
                    {
                        nodesQueue.Enqueue((edgesDictionaryItemCur, currentNodeDepth + 1));
                    }
                }
            }

            maxNodeDepths.Add((node, maxNodeDepth));
        }

        return maxNodeDepths;
    }
}