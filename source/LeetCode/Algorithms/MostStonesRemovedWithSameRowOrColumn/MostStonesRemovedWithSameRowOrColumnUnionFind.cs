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

namespace LeetCode.Algorithms.MostStonesRemovedWithSameRowOrColumn;

/// <inheritdoc />
public class MostStonesRemovedWithSameRowOrColumnUnionFind : IMostStonesRemovedWithSameRowOrColumn
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="stones"></param>
    /// <returns></returns>
    public int RemoveStones(int[][] stones)
    {
        var unionFind = new UnionFind(20002);

        foreach (var stone in stones)
        {
            unionFind.Union(stone[0], stone[1] + 10001);
        }

        return stones.Length - unionFind.ComponentCount;
    }

    private class UnionFind
    {
        private readonly int[] _parent;
        private readonly HashSet<int> _uniqueNodes = [];

        public UnionFind(int n)
        {
            _parent = new int[n];

            Array.Fill(_parent, -1);
        }

        public int ComponentCount { get; private set; }

        private int Find(int node)
        {
            if (!_uniqueNodes.Contains(node))
            {
                ComponentCount++;

                _uniqueNodes.Add(node);
            }

            if (_parent[node] == -1)
            {
                return node;
            }

            return _parent[node] = Find(_parent[node]);
        }

        public void Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);

            if (rootX == rootY)
            {
                return;
            }

            _parent[rootX] = rootY;

            ComponentCount--;
        }
    }
}