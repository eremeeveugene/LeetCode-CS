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
public sealed class MaximumLengthSubstringWithTwoOccurrencesSlidingWindow : IMaximumLengthSubstringWithTwoOccurrences
{
    private const byte AlphabetLength = 'z' - 'a' + 1;
    private const int MaxOccurrences = 2;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of s
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaximumLengthSubstring(string s)
    {
        var n = s.Length;

        Span<int> counts = stackalloc int[AlphabetLength];

        var left = 0;
        var maximumLength = 0;

        for (var right = 0; right < n; right++)
        {
            var rightChar = s[right] - 'a';

            counts[rightChar]++;

            while (counts[rightChar] > MaxOccurrences)
            {
                var leftChar = s[left] - 'a';

                counts[leftChar]--;

                left++;
            }

            var length = right - left + 1;

            maximumLength = Math.Max(maximumLength, length);
        }

        return maximumLength;
    }
}