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

namespace LeetCode.Algorithms.FindCenterOfStarGraph;

/// <inheritdoc />
public sealed class FindCenterOfStarGraphDictionary : IFindCenterOfStarGraph
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FindCenter(int[][] edges)
    {
        var nodeToDegreeDictionary = new Dictionary<int, int>();

        var center = 0;

        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];
            var firstNode = edge[0];
            var secondNode = edge[1];

            if (!nodeToDegreeDictionary.TryAdd(firstNode, 1))
            {
                nodeToDegreeDictionary[firstNode]++;
            }

            if (!nodeToDegreeDictionary.TryAdd(secondNode, 1))
            {
                nodeToDegreeDictionary[secondNode]++;
            }

            if (nodeToDegreeDictionary[firstNode] == edges.Length)
            {
                center = firstNode;
            }

            if (nodeToDegreeDictionary[secondNode] == edges.Length)
            {
                center = secondNode;
            }
        }

        return center;
    }
}