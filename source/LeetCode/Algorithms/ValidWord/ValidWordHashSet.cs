// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ValidWord;

/// <inheritdoc />
public class ValidWordHashSet : IValidWord
{
    private static readonly HashSet<char> Digits =
    [
        ..Enumerable.Range('0', 10).Select(c => (char)c)
    ];

    private static readonly HashSet<char> Letters =
    [
        ..Enumerable.Range('a', 26).Select(c => (char)c)
            .Concat(Enumerable.Range('A', 26).Select(c => (char)c))
    ];

    private static readonly HashSet<char> Vowels =
    [
        'a', 'e', 'i', 'o', 'u',
        'A', 'E', 'I', 'O', 'U'
    ];

    private static readonly HashSet<char> Consonants = [..Letters.Except(Vowels)];

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public bool IsValid(string word)
    {
        if (word.Length < 3)
        {
            return false;
        }

        var hasVowel = false;
        var hasConsonant = false;

        foreach (var character in word)
        {
            if (!Letters.Contains(character) && !Digits.Contains(character))
            {
                return false;
            }

            hasVowel |= Vowels.Contains(character);
            hasConsonant |= Consonants.Contains(character);
        }

        return hasVowel && hasConsonant;
    }
}