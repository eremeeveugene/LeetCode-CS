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
public class ReplaceWordsHashSet : IReplaceWords
{
    /// <summary>
    ///     Time complexity - O(n + m + k * L), where n is the number of words in the dictionary, k is the number of words in
    ///     the sentence, m is the length of the sentence, and L is the length of the longest word
    ///     Space complexity - O(n * L + m), where n is the number of words in the dictionary, m is the length of the sentence,
    ///     and L is the length of the longest word
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="sentence"></param>
    /// <returns></returns>
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var dictionaryHashSet = new HashSet<string>(dictionary);

        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            for (var j = 0; j < word.Length; j++)
            {
                var prefix = word[..(j + 1)];

                if (!dictionaryHashSet.Contains(prefix))
                {
                    continue;
                }

                words[i] = prefix;

                break;
            }
        }

        return string.Join(' ', words);
    }
}