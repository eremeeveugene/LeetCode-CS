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
public class ReplaceWordsSorting : IReplaceWords
{
    /// <summary>
    ///     Time complexity - O(n log n + k * n * L), where n is the number of words in the dictionary, k is the number of
    ///     words in the sentence, and L is the length of the longest word
    ///     Space complexity - O(n + k), where n is the number of words in the dictionary, k is the number of words in the
    ///     sentence
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var words = sentence.Split(' ');

        var resultWords = new string[words.Length];

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            var isFound = false;

            foreach (var dictionaryWord in dictionary.Order())
            {
                if (!word.StartsWith(dictionaryWord))
                {
                    continue;
                }

                resultWords[i] = dictionaryWord;

                isFound = true;

                break;
            }

            if (!isFound)
            {
                resultWords[i] = word;
            }
        }

        return string.Join(' ', resultWords);
    }
}