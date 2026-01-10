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

namespace LeetCode.Algorithms.LetterTilePossibilities;

/// <inheritdoc />
public sealed class LetterTilePossibilitiesRecursive : ILetterTilePossibilities
{
    private const int Count = 'Z' - 'A' + 1;

    /// <summary>
    ///     Time complexity - O(n * n!)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="tiles"></param>
    /// <returns></returns>
    public int NumTilePossibilities(string tiles)
    {
        var charCount = new int[Count];

        foreach (var tile in tiles)
        {
            charCount[tile - 'A']++;
        }

        return FindSequences(charCount);
    }

    private static int FindSequences(int[] charCount)
    {
        var totalCount = 0;

        for (var i = 0; i < Count; i++)
        {
            if (charCount[i] == 0)
            {
                continue;
            }

            totalCount++;

            charCount[i]--;

            totalCount += FindSequences(charCount);

            charCount[i]++;
        }

        return totalCount;
    }
}