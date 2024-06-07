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

namespace LeetCode.Algorithms.ReplaceWords;

/// <inheritdoc />
public class ReplaceWordsBruteForce : IReplaceWords
{
    /// <summary>
    ///     Time complexity - O(m + n log n + k * n * L), where n is the number of words in the dictionary, m is the length of
    ///     the sentence, k is the number of words in the sentence, and L is the length of the longest word
    ///     Space complexity - O(m + n), where n is the number of words in the dictionary, m is the length of the sentence
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            foreach (var dictionaryWord in dictionary.Order())
            {
                if (!word.StartsWith(dictionaryWord))
                {
                    continue;
                }

                words[i] = dictionaryWord;

                break;
            }
        }

        return string.Join(' ', words);
    }
}