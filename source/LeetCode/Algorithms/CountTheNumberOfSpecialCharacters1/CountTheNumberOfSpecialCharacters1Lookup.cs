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

namespace LeetCode.Algorithms.CountTheNumberOfSpecialCharacters1;

/// <inheritdoc />
public sealed class CountTheNumberOfSpecialCharacters1Lookup : ICountTheNumberOfSpecialCharacters1
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int NumberOfSpecialChars(string word)
    {
        Span<bool> lower = stackalloc bool[AlphabetLength];
        Span<bool> upper = stackalloc bool[AlphabetLength];

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            if (char.IsLower(c))
            {
                lower[c - 'a'] = true;
            }
            else
            {
                upper[c - 'A'] = true;
            }
        }

        var result = 0;

        for (var i = 0; i < AlphabetLength; i++)
        {
            if (lower[i] && upper[i])
            {
                result++;
            }
        }

        return result;
    }
}