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

namespace LeetCode.Algorithms.FindCommonCharacters;

/// <inheritdoc />
public sealed class FindCommonCharactersDictionary : IFindCommonCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is the number of words and m is the maximum length of the words
    ///     Space complexity - O(m), m is the maximum length of the words
    /// </remarks>
    public IList<string> CommonChars(string[] words)
    {
        var commonChars = new List<char>(words[0]);

        for (var i = 1; i < words.Length; i++)
        {
            var word = words[i];

            var wordDictionary = CountChars(word);

            var charsToRemove = new List<char>();

            for (var j = 0; j < commonChars.Count; j++)
            {
                var c = commonChars[j];

                if (wordDictionary.TryGetValue(c, out var count) && count > 0)
                {
                    wordDictionary[c]--;
                }
                else
                {
                    charsToRemove.Add(c);
                }
            }

            for (var j = 0; j < charsToRemove.Count; j++)
            {
                var charToRemove = charsToRemove[j];

                commonChars.Remove(charToRemove);
            }
        }

        var result = new List<string>(commonChars.Count);

        for (var i = 0; i < commonChars.Count; i++)
        {
            var c = commonChars[i];

            result.Add(c.ToString());
        }

        return result;
    }

    private static Dictionary<char, int> CountChars(string word)
    {
        var charToCountDictionary = new Dictionary<char, int>();

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            if (!charToCountDictionary.TryAdd(c, 1))
            {
                charToCountDictionary[c]++;
            }
        }

        return charToCountDictionary;
    }
}