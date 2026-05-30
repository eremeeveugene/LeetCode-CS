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

namespace LeetCode.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

/// <inheritdoc />
public sealed class ShortestDistanceAfterRoadAdditionQueries1BreadthFirstSearch : IShortestDistanceAfterRoadAdditionQueries1
{
    /// <summary>
    ///     Time complexity - O(n * q)
    ///     Space complexity - O(n + q)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        var adjacencyList = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            adjacencyList[i] = [];
        }

        for (var i = 0; i < n - 1; i++)
        {
            adjacencyList[i].Add(i + 1);
        }

        var distances = new int[n];

        for (var i = 1; i < distances.Length; i++)
        {
            distances[i] = i;
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var fromNode = queries[i][0];
            var toNode = queries[i][1];

            adjacencyList[fromNode].Add(toNode);

            if (distances[fromNode] + 1 < distances[toNode])
            {
                distances[toNode] = distances[fromNode] + 1;

                UpdateDistancesFrom(adjacencyList, distances, toNode);
            }

            result[i] = distances[n - 1] == int.MaxValue ? -1 : distances[n - 1];
        }

        return result;
    }

    private static void UpdateDistancesFrom(List<int>[] adjacencyList, int[] distances, int startNode)
    {
        var queue = new Queue<int>();

        queue.Enqueue(startNode);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            foreach (var neighbor in adjacencyList[currentNode].Where(neighbor => distances[currentNode] + 1 < distances[neighbor]))
            {
                distances[neighbor] = distances[currentNode] + 1;

                queue.Enqueue(neighbor);
            }
        }
    }
}