// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using System.Text;

namespace LeetCode.Algorithms.LexicographicallySmallestEquivalentString;

/// <inheritdoc />
public class LexicographicallySmallestEquivalentStringAdjacencyUnionFind : ILexicographicallySmallestEquivalentString
{
    private const int Length = 'z' - 'a' + 1;

    /// <summary>
    ///     Time complexity - O(m + n), where m is the length of s1 and n is the length of baseStr
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <param name="baseStr"></param>
    /// <returns></returns>
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var parent = new int[Length];

        for (var i = 0; i < Length; i++)
        {
            parent[i] = i;
        }

        for (var i = 0; i < s1.Length; i++)
        {
            var c1 = s1[i] - 'a';
            var c2 = s2[i] - 'a';

            Union(c1, c2, parent);
        }

        var resultStringBuilder = new StringBuilder(baseStr.Length);

        foreach (var c in baseStr)
        {
            var i = Find(c - 'a', parent);

            resultStringBuilder.Append((char)(i + 'a'));
        }

        return resultStringBuilder.ToString();
    }

    private static void Union(int x, int y, int[] parent)
    {
        var rootX = Find(x, parent);
        var rootY = Find(y, parent);

        if (rootX == rootY)
        {
            return;
        }

        if (rootX < rootY)
        {
            parent[rootY] = rootX;
        }
        else
        {
            parent[rootX] = rootY;
        }
    }

    private static int Find(int x, int[] parent)
    {
        var root = x;

        while (parent[root] != root)
        {
            root = parent[root];
        }

        while (x != root)
        {
            var p = parent[x];

            parent[x] = root;

            x = p;
        }

        return root;
    }
}