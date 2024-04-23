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
public class MinimumHeightTreesBreadthFirstSearch : IMinimumHeightTrees
{
    /// <summary>
    ///     Time complexity - O(V * (V + E)), where V is the number of vertices(nodes) and E is the number of edges.
    ///     Space complexity - O(V + E), where V is the number of vertices(nodes) and E is the number of edges.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        var nodesDictionary = GetNodesDictionary(edges);

        var maxNodeDepths = GetMaxNodeDepth(nodesDictionary);

        var minDepth = maxNodeDepths.Select(v => v.maxDepth).Min();

        return maxNodeDepths.Where(v => v.maxDepth.Equals(minDepth)).Select(v => v.node).ToList();
    }

    private static Dictionary<int, List<int>> GetNodesDictionary(IEnumerable<int[]> edges)
    {
        var nodesDictionary = new Dictionary<int, List<int>>();

        foreach (var edge in edges)
        {
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

        foreach (var node in nodesDictionary)
        {
            var maxNodeDepth = 0;

            var nodesQueue = new Queue<(int, int)>();

            var visitedNodes = new HashSet<int> { node.Key };

            foreach (var value in node.Value)
            {
                nodesQueue.Enqueue((value, 1));
            }

            while (nodesQueue.Count > 0)
            {
                var (currentNode, currentNodeDepth) = nodesQueue.Dequeue();

                visitedNodes.Add(currentNode);

                foreach (var edgesDictionaryItemCur in nodesDictionary[currentNode])
                {
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

            maxNodeDepths.Add((node.Key, maxNodeDepth));
        }

        return maxNodeDepths;
    }
}