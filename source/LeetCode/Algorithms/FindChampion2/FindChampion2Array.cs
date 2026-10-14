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
public sealed class FindChampion2Array : IFindChampion2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(e + n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int FindChampion(int n, int[][] edges)
    {
        var hasIncomingEdge = new bool[n];

        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];

            hasIncomingEdge[edge[1]] = true;
        }

        var champion = -1;

        for (var j = 0; j < n; j++)
        {
            if (hasIncomingEdge[j])
            {
                continue;
            }

            if (champion != -1)
            {
                return -1;
            }

            champion = j;
        }

        return champion;
    }
}