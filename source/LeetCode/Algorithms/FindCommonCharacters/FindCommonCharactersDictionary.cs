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
public class FindCommonCharactersDictionary : IFindCommonCharacters
{
    /// <summary>
    ///     Time complexity - O(n * m), where n is the number of words and m is the maximum length of the words
    ///     Space complexity - O(m), m is the maximum length of the words
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> CommonChars(string[] words)
    {
        var commonChars = words[0].ToList();

        foreach (var word in words.Skip(1))
        {
            var wordDictionary = new Dictionary<char, int>();

            foreach (var c in word.Where(c => !wordDictionary.TryAdd(c, 1)))
            {
                wordDictionary[c]++;
            }

            var charsToRemove = new List<char>();

            foreach (var c in commonChars)
            {
                if (wordDictionary.TryGetValue(c, out var count) && count > 0)
                {
                    wordDictionary[c]--;
                }
                else
                {
                    charsToRemove.Add(c);
                }
            }

            foreach (var charToRemove in charsToRemove)
            {
                commonChars.Remove(charToRemove);
            }
        }

        return commonChars.Select(c => c.ToString()).ToList();
    }
}