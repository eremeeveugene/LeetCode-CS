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

namespace LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence2;

/// <inheritdoc />
public sealed class LongestUnequalAdjacentGroupsSubsequence2DynamicProgramming : ILongestUnequalAdjacentGroupsSubsequence2
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2 * m)
    ///     Space complexity - O(n)
    /// </remarks>
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
    {
        var n = words.Length;

        Span<int> lengths = stackalloc int[n];
        Span<int> previousIndices = stackalloc int[n];

        var bestEnd = 0;

        for (var i = 0; i < n; i++)
        {
            lengths[i] = 1;
            previousIndices[i] = -1;

            var word = words[i];
            var group = groups[i];

            for (var j = 0; j < i; j++)
            {
                if (groups[j] == group || lengths[j] + 1 <= lengths[i] || !IsHammingDistanceOne(words[j], word))
                {
                    continue;
                }

                lengths[i] = lengths[j] + 1;
                previousIndices[i] = j;
            }

            if (lengths[i] > lengths[bestEnd])
            {
                bestEnd = i;
            }
        }

        var result = new string[lengths[bestEnd]];

        var currentIndex = bestEnd;

        for (var i = result.Length - 1; i >= 0; i--)
        {
            result[i] = words[currentIndex];

            currentIndex = previousIndices[currentIndex];
        }

        return result;
    }

    /// <summary>
    ///     Determines whether two distinct words have equal lengths and differ in exactly one character.
    /// </summary>
    /// <param name="first">The first word.</param>
    /// <param name="second">The second word, distinct from <paramref name="first" />.</param>
    /// <returns><see langword="true" /> if the Hamming distance between the words is one; otherwise, <see langword="false" />.</returns>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    private static bool IsHammingDistanceOne(string first, string second)
    {
        var n = first.Length;

        if (n != second.Length)
        {
            return false;
        }

        var differences = 0;

        for (var i = 0; i < n; i++)
        {
            if (first[i] == second[i])
            {
                continue;
            }

            differences++;

            if (differences > 1)
            {
                return false;
            }
        }

        return true;
    }
}