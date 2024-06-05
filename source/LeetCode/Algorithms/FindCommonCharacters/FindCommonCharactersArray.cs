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

namespace LeetCode.Algorithms.FindCommonCharacters;

/// <inheritdoc />
public class FindCommonCharactersArray : IFindCommonCharacters
{
    /// <summary>
    ///     Time complexity - O(n * m), where n is the number of words and m is the maximum length of the words
    ///     Space complexity - O(n * m), where n is the number of words and m is the maximum length of the words
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> CommonChars(string[] words)
    {
        var minFrequency = new int[26];

        Array.Fill(minFrequency, int.MaxValue);

        foreach (var word in words)
        {
            var charCount = new int[26];

            foreach (var c in word)
            {
                charCount[c - 'a']++;
            }

            for (var i = 0; i < 26; i++)
            {
                minFrequency[i] = Math.Min(minFrequency[i], charCount[i]);
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