// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindWordsContainingCharacter;

/// <inheritdoc />
public class FindWordsContainingCharacterDictionary : IFindWordsContainingCharacter
{
    /// <summary>
    ///     Time complexity - O(n * k), where n is the number of words in the words array, and k is the average number of
    ///     unique characters per word
    ///     Space complexity - O(n * k), where n is the number of words in the words array, and k is the average number of
    ///     unique characters per word
    /// </summary>
    /// <param name="words"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var charToWordIndexDictionary = new Dictionary<char, List<int>>();

        for (var i = 0; i < words.Length; i++)
        {
            var uniqueChars = new HashSet<char>(words[i]);

            foreach (var ch in uniqueChars)
            {
                if (!charToWordIndexDictionary.TryGetValue(ch, out var value))
                {
                    value = [];
                    charToWordIndexDictionary[ch] = value;
                }

                value.Add(i);
            }
        }

        return charToWordIndexDictionary.TryGetValue(x, out var indices) ? indices : [];
    }
}