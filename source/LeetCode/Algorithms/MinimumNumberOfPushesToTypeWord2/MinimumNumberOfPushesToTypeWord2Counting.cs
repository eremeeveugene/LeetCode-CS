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

namespace LeetCode.Algorithms.MinimumNumberOfPushesToTypeWord2;

/// <inheritdoc />
public sealed class MinimumNumberOfPushesToTypeWord2Counting : IMinimumNumberOfPushesToTypeWord2
{
    private const byte AlphabetLength = 'z' - 'a' + 1;
    private const int KeysCount = 8;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of word
    ///     Space complexity - O(1)
    /// </remarks>
    public int MinimumPushes(string word)
    {
        Span<int> counts = stackalloc int[AlphabetLength];

        var n = word.Length;

        for (var i = 0; i < n; i++)
        {
            var letter = word[i];
            var letterIndex = letter - 'a';

            counts[letterIndex]++;
        }

        counts.Sort();

        var result = 0;
        var rank = 0;

        for (var i = AlphabetLength - 1; i >= 0; i--)
        {
            var count = counts[i];

            if (count == 0)
            {
                break;
            }

            var pushes = (rank / KeysCount) + 1;

            result += count * pushes;

            rank++;
        }

        return result;
    }
}