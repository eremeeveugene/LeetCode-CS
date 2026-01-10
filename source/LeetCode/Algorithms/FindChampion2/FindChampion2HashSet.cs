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
    /// <summary>
    ///     Time complexity - O(e + n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int FindChampion(int n, int[][] edges)
    {
        var hashSet = new HashSet<int>();

        for (var i = 0; i < n; i++)
        {
            hashSet.Add(i);
        }

        foreach (var edge in edges)
        {
            hashSet.Remove(edge[1]);
        }

        if (hashSet.Count == 1)
        {
            return hashSet.First();
        }

        return -1;
    }
}