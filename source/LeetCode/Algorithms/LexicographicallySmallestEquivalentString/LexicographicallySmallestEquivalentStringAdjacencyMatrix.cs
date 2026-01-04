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

using System.Text;

namespace LeetCode.Algorithms.LexicographicallySmallestEquivalentString;

/// <inheritdoc />
public class LexicographicallySmallestEquivalentStringAdjacencyMatrix : ILexicographicallySmallestEquivalentString
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
        var adjacencyMatrix = new bool[Length, Length];

        for (var i = 0; i < Length; i++)
        {
            adjacencyMatrix[i, i] = true;
        }

        for (var i = 0; i < s1.Length; i++)
        {
            var c1 = s1[i] - 'a';
            var c2 = s2[i] - 'a';

            adjacencyMatrix[c1, c2] = true;
            adjacencyMatrix[c2, c1] = true;
        }

        for (var i = 0; i < Length; i++)
        {
            for (var j = 0; j < Length; j++)
            {
                if (!adjacencyMatrix[i, j])
                {
                    continue;
                }

                for (var k = 0; k < Length; k++)
                {
                    if (adjacencyMatrix[i, k])
                    {
                        adjacencyMatrix[j, k] = true;
                    }
                }
            }
        }

        var resultStringBuilder = new StringBuilder(baseStr.Length);

        foreach (var c in baseStr)
        {
            var i = c - 'a';

            for (var j = 0; j < Length; j++)
            {
                if (!adjacencyMatrix[i, j])
                {
                    continue;
                }

                resultStringBuilder.Append((char)(j + 'a'));

                break;
            }
        }

        return resultStringBuilder.ToString();
    }
}