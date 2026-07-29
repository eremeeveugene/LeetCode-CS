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

namespace LeetCode.Algorithms.SmallestPalindromicRearrangement1;

/// <inheritdoc />
public sealed class SmallestPalindromicRearrangement1Counting : ISmallestPalindromicRearrangement1
{
    private const byte AlphabetLength = 'z' - 'a' + 1;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n), where n is the length of s
    ///     Space complexity - O(n)
    /// </remarks>
    public string SmallestPalindrome(string s)
    {
        Span<int> counts = stackalloc int[AlphabetLength];

        var n = s.Length;

        for (var i = 0; i < n; i++)
        {
            var letter = s[i];
            var letterIndex = ToIndex(letter);

            counts[letterIndex]++;
        }

        Span<char> result = stackalloc char[n];

        var left = 0;
        var right = n - 1;
        var middle = -1;

        for (var i = 0; i < AlphabetLength; i++)
        {
            var count = counts[i];
            var letter = ToLetter(i);

            if (count % 2 == 1)
            {
                middle = i;
            }

            var half = count / 2;

            for (var j = 0; j < half; j++)
            {
                result[left] = letter;
                result[right] = letter;

                left++;
                right--;
            }
        }

        if (middle >= 0)
        {
            result[left] = ToLetter(middle);
        }

        return new string(result);
    }

    /// <summary>
    ///     Converts a lowercase letter to its zero-based alphabet index.
    /// </summary>
    /// <param name="letter">The lowercase letter to convert.</param>
    /// <returns>The zero-based index of <paramref name="letter" /> within the alphabet.</returns>
    private static int ToIndex(char letter)
    {
        return letter - 'a';
    }

    /// <summary>
    ///     Converts a zero-based alphabet index to its corresponding lowercase letter.
    /// </summary>
    /// <param name="index">The zero-based alphabet index to convert.</param>
    /// <returns>The lowercase letter at <paramref name="index" /> within the alphabet.</returns>
    private static char ToLetter(int index)
    {
        return (char)(index + 'a');
    }
}