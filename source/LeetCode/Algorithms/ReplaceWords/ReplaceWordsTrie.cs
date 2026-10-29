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

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.ReplaceWords;

/// <inheritdoc />
public sealed class ReplaceWordsTrie : IReplaceWords
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n * L + k * L), where n is the number of words in the dictionary, L is the length of the word,
    ///     k is the number of words in the sentence
    ///     Space complexity - O(n * L + m), where n is the number of words in the dictionary, L is the length of the word, m
    ///     is the length of the sentence
    /// </remarks>
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var trie = new Trie(dictionary);

        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            var current = trie.Root;

            for (var j = 0; j < word.Length; j++)
            {
                if (current.Word != null || !current.Children.TryGetValue(word[j], out var child))
                {
                    break;
                }

                current = child;
            }

            if (current.Word != null)
            {
                words[i] = current.Word;
            }
        }

        return string.Join(' ', words);
    }
}