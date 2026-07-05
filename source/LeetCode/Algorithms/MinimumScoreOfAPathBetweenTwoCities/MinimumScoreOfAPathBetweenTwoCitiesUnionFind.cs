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

namespace LeetCode.Algorithms.MinimumScoreOfAPathBetweenTwoCities;

/// <inheritdoc />
public sealed class MinimumScoreOfAPathBetweenTwoCitiesUnionFind : IMinimumScoreOfAPathBetweenTwoCities
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O((n + m) * log(n)), where n is the number of cities and m is the number of roads
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinScore(int n, int[][] roads)
    {
        Span<int> parent = stackalloc int[n + 1];

        for (var i = 1; i < parent.Length; i++)
        {
            parent[i] = i;
        }

        var m = roads.Length;

        for (var i = 0; i < m; i++)
        {
            var road = roads[i];

            var a = road[0];
            var b = road[1];

            Union(parent, a, b);
        }

        var minimumDistance = int.MaxValue;

        var firstComponent = Find(parent, 1);

        for (var i = 0; i < roads.Length; i++)
        {
            var road = roads[i];

            var a = road[0];
            var distance = road[2];

            var roadComponent = Find(parent, a);

            if (roadComponent == firstComponent)
            {
                minimumDistance = Math.Min(minimumDistance, distance);
            }
        }

        return minimumDistance;
    }

    /// <summary>
    ///     Merges the disjoint sets containing <paramref name="x" /> and <paramref name="y" /> into a single set.
    /// </summary>
    /// <param name="parent">The union-find parent array.</param>
    /// <param name="x">The first node to union.</param>
    /// <param name="y">The second node to union.</param>
    /// <remarks>
    ///     Time complexity - O(log(n)), where n is the number of cities
    ///     Space complexity - O(log(n)), where n is the number of cities, for the recursive call stack
    /// </remarks>
    private static void Union(Span<int> parent, int x, int y)
    {
        var rootX = Find(parent, x);
        var rootY = Find(parent, y);

        if (rootX == rootY)
        {
            return;
        }

        parent[rootX] = rootY;
    }

    /// <summary>
    ///     Finds the root of the disjoint set containing <paramref name="node" />, compressing the path along the way.
    /// </summary>
    /// <param name="parent">The union-find parent array.</param>
    /// <param name="node">The node whose set root to find.</param>
    /// <returns>The root node of the set containing <paramref name="node" />.</returns>
    /// <remarks>
    ///     Time complexity - O(log(n)), where n is the number of cities
    ///     Space complexity - O(log(n)), where n is the number of cities, for the recursive call stack
    /// </remarks>
    private static int Find(Span<int> parent, int node)
    {
        if (parent[node] == node)
        {
            return node;
        }

        return parent[node] = Find(parent, parent[node]);
    }
}