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

namespace LeetCode.Algorithms.KeyboardRow;

/// <inheritdoc />
public sealed class KeyboardRowLookup : IKeyboardRow
{
    private static readonly byte[] CharIndexToRow = [1, 2, 2, 1, 0, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 2];

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public string[] FindWords(string[] words)
    {
        var result = new List<string>(words.Length);

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            if (IsSingleRow(word))
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }

    private static bool IsSingleRow(string word)
    {
        var firstRow = GetRow(word[0]);

        for (var i = 1; i < word.Length; i++)
        {
            var c = word[i];

            if (GetRow(c) == firstRow)
            {
                continue;
            }

            return false;
        }

        return true;
    }

    private static int GetRow(char c)
    {
        var charIndex = GetCharIndex(c);

        return CharIndexToRow[charIndex];
    }

    private static int GetCharIndex(char c)
    {
        return (c | 32) - 'a';
    }
}