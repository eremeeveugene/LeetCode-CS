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

namespace LeetCode.Algorithms.MaximumLengthSubstringWithTwoOccurrences;

/// <inheritdoc />
public sealed class MaximumLengthSubstringWithTwoOccurrencesBruteForce : IMaximumLengthSubstringWithTwoOccurrences
{
    private const byte AlphabetLength = 'z' - 'a' + 1;
    private const int MaxOccurrences = 2;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n^2), where n is the length of s
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumLengthSubstring(string s)
    {
        var n = s.Length;

        var maximumLength = 0;

        Span<int> counts = stackalloc int[AlphabetLength];

        for (var start = 0; start < n; start++)
        {
            counts.Clear();

            for (var end = start; end < n; end++)
            {
                var character = s[end] - 'a';

                counts[character]++;

                if (counts[character] > MaxOccurrences)
                {
                    break;
                }

                var length = end - start + 1;

                maximumLength = Math.Max(maximumLength, length);
            }
        }

        return maximumLength;
    }
}