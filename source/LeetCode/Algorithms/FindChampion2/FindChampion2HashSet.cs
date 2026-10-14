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

namespace LeetCode.Algorithms.FindChampion2;

/// <inheritdoc />
public sealed class FindChampion2HashSet : IFindChampion2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(e + n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FindChampion(int n, int[][] edges)
    {
        var hashSet = new HashSet<int>();

        for (var i = 0; i < n; i++)
        {
            hashSet.Add(i);
        }

        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];

            hashSet.Remove(edge[1]);
        }

        if (hashSet.Count == 1)
        {
            var candidates = new int[1];

            hashSet.CopyTo(candidates);

            return candidates[0];
        }

        return -1;
    }
}