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
public sealed class FindCommonCharactersArray : IFindCommonCharacters
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * m), where n is the number of words and m is the maximum length of the words
    ///     Space complexity - O(n * m), where n is the number of words and m is the maximum length of the words
    /// </remarks>
    public IList<string> CommonChars(string[] words)
    {
        var minFrequency = new int[26];

        Array.Fill(minFrequency, int.MaxValue);

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            var charCount = new int[26];

            for (var j = 0; j < word.Length; j++)
            {
                var c = word[j];

                charCount[c - 'a']++;
            }

            for (var j = 0; j < 26; j++)
            {
                minFrequency[j] = Math.Min(minFrequency[j], charCount[j]);
            }
        }

        var commonChars = new List<string>();

        for (var i = 0; i < 26; i++)
        {
            for (var j = 0; j < minFrequency[i]; j++)
            {
                commonChars.Add(((char)(i + 'a')).ToString());
            }
        }

        return commonChars;
    }
}