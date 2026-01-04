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

namespace LeetCode.Algorithms.ValidWord;

/// <inheritdoc />
public class ValidWordIterative : IValidWord
{
    private static readonly HashSet<char> Vowels =
    [
        'a', 'e', 'i', 'o', 'u'
    ];

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
            if (!char.IsLetterOrDigit(character))
            {
                return false;
            }

            if (char.IsDigit(character))
            {
                continue;
            }

            if (Vowels.Contains(char.ToLower(character)))
            {
                hasVowel = true;
            }
            else
            {
                hasConsonant = true;
            }
        }

        return hasVowel && hasConsonant;
    }
}