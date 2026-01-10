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

namespace LeetCode.Algorithms.VowelSpellchecker;

/// <inheritdoc />
public sealed class VowelSpellcheckerDictionary : IVowelSpellchecker
{
    /// <summary>
    ///     Time complexity - O(n * l), where n is the number of words in wordlist and l is the average word length
    ///     Space complexity - O(n * l), where n is the number of words in wordlist and l is the average word length
    /// </summary>
    /// <param name="wordlist"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public string[] Spellchecker(string[] wordlist, string[] queries)
    {
        var wordsCount = wordlist.Length;

        var wordsHashSet = new HashSet<string>(wordsCount);
        var lowercaseWordsDictionary = new Dictionary<string, string>(wordsCount);
        var maskedWordsDictionary = new Dictionary<string, string>(wordsCount);

        foreach (var word in wordlist)
        {
            wordsHashSet.Add(word);

            var lowercaseWord = GetLowercaseWord(word);

            lowercaseWordsDictionary.TryAdd(lowercaseWord, word);

            var maskedWord = GetMaskedWord(lowercaseWord);

            maskedWordsDictionary.TryAdd(maskedWord, word);
        }

        var result = new string[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];

            if (wordsHashSet.Contains(query))
            {
                result[i] = query;

                continue;
            }

            var lowercaseWord = GetLowercaseWord(query);

            if (lowercaseWordsDictionary.TryGetValue(lowercaseWord, out var capMatch))
            {
                result[i] = capMatch;

                continue;
            }

            var maskedWord = GetMaskedWord(lowercaseWord);

            if (maskedWordsDictionary.TryGetValue(maskedWord, out var vowelMatch))
            {
                result[i] = vowelMatch;
            }
            else
            {
                result[i] = string.Empty;
            }
        }

        return result;
    }

    private static string GetLowercaseWord(string word)
    {
        return string.Create(word.Length, word, (span, source) =>
        {
            for (var i = 0; i < source.Length; i++)
            {
                span[i] = char.ToLowerInvariant(source[i]);
            }
        });
    }

    private static string GetMaskedWord(string word)
    {
        Span<char> buffer = stackalloc char[word.Length];

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            buffer[i] = IsVowel(c) ? '*' : c;
        }

        return new string(buffer);
    }

    private static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}