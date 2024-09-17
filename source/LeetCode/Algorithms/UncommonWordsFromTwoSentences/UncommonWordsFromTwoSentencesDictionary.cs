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

namespace LeetCode.Algorithms.UncommonWordsFromTwoSentences;

/// <inheritdoc />
public class UncommonWordsFromTwoSentencesDictionary : IUncommonWordsFromTwoSentences
{
    /// <summary>
    ///     Time complexity - O(n + m)
    ///     Space complexity - O(n + m)
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var wordsDictionary = new Dictionary<string, int>();

        foreach (var word in s1.Split(' '))
        {
            if (!wordsDictionary.TryAdd(word, 1))
            {
                wordsDictionary[word]++;
            }
        }

        foreach (var word in s2.Split(' '))
        {
            if (!wordsDictionary.TryAdd(word, 1))
            {
                wordsDictionary[word]++;
            }
        }

        return wordsDictionary.Where(w => w.Value == 1).Select(w => w.Key).ToArray();
    }
}