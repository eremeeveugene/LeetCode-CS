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
public sealed class LexicographicallySmallestEquivalentStringAdjacencyMatrix : ILexicographicallySmallestEquivalentString
{
    private const int Length = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(m + n), where m is the length of s1 and n is the length of baseStr
    ///     Space complexity - O(1)
    /// </remarks>
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

        PropagateEquivalences(adjacencyMatrix);

        var resultStringBuilder = new StringBuilder(baseStr.Length);

        for (var i = 0; i < baseStr.Length; i++)
        {
            resultStringBuilder.Append(GetSmallestEquivalent(adjacencyMatrix, baseStr[i] - 'a'));
        }

        return resultStringBuilder.ToString();
    }

    private static void PropagateEquivalences(bool[,] adjacencyMatrix)
    {
        for (var i = 0; i < Length; i++)
        {
            for (var j = 0; j < Length; j++)
            {
                if (adjacencyMatrix[i, j])
                {
                    CopyEquivalences(adjacencyMatrix, i, j);
                }
            }
        }
    }

    private static void CopyEquivalences(bool[,] adjacencyMatrix, int i, int j)
    {
        for (var k = 0; k < Length; k++)
        {
            if (adjacencyMatrix[i, k])
            {
                adjacencyMatrix[j, k] = true;
            }
        }
    }

    private static char GetSmallestEquivalent(bool[,] adjacencyMatrix, int i)
    {
        var smallest = i;

        for (var j = 0; j < i; j++)
        {
            if (!adjacencyMatrix[i, j])
            {
                continue;
            }

            smallest = j;

            break;
        }

        return (char)(smallest + 'a');
    }
}