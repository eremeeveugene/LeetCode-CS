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
    ///     Time complexity - O(n * L), where n is the number of words and L is the average length of the words
    ///     Space complexity - O(L), L is the average length of the words
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public IList<string> CommonChars(string[] words)
    {
        var result = words[0].ToArray();

        foreach (var word in words)
        {
            var wordDictionary = new Dictionary<char, int>();

            foreach (var c in word.Where(c => !wordDictionary.TryAdd(c, 1)))
            {
                wordDictionary[c]++;
            }

            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] == ' ')
                {
                    continue;
                }

                if (wordDictionary.TryGetValue(result[i], out var value))
                {
                    if (value > 0)
                    {
                        wordDictionary[result[i]] = --value;
                    }
                    else
                    {
                        result[i] = ' ';
                    }
                }
                else
                {
                    result[i] = ' ';
                }
            }
        }

        return result.Where(c => c != ' ').Select(c => c.ToString()).ToArray();
    }
}